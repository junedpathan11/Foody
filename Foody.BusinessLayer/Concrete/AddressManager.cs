using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(int id)
        {
            _addressDal.Delete(id);
        }

        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();
        }

        public Address TGetByID(int id)
        {
            return _addressDal.GetByID(id);
        }

        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
