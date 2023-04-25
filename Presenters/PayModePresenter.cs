using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.mvp.Views;
using Supermarket.mvp.Models;
using System.Security.AccessControl;
using Microsoft.Data.SqlClient;

namespace Supermarket.mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }
        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id=Convert.ToInt32(view.PayModeId);
            payMode.Name=view.PayModeName;
            payMode.Observations = view.PayModeObservation;

           
            try
            { 
                new ModelDataValidation().Validate(payMode);
                if(view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added successfuly";
                }
                view.IsSuccessful= true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch(Exception ex)  
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }
        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName= "";
            view.PayModeObservation= "";
            }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;

            repository.Delete(payMode.Id);
            view.IsSuccessful = true;
            view.Message = "Pay Mode Deleted Successfully";
            loadAllPayModeList();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observations;

            view.IsEdit=true;
        }

        private void AddPayMode(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo Clic en el boton nuevo");
        }
        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue==false) 
            {
                payModeList=repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
        
    }
}
