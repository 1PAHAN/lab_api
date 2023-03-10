using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private IProductRepository _productRepository;
        private ICustomerRepository _customerRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null) 
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null) 
                    _productRepository = new ProductRepository(_repositoryContext);
                return _productRepository;
            }
        }
        public ICustomerRepository Customer
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_repositoryContext);
                return _customerRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();

        public Task SaveAsync()
        {
            return _repositoryContext.SaveChangesAsync();
        }
    }
}
