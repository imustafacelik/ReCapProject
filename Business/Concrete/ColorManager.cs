using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetById(int id)
        {
            return _colorDal.GetAll(c => c.Id == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        IResult IColorService.Add(Color color)
        {
            throw new NotImplementedException();
        }

        IResult IColorService.Delete(Color color)
        {
            throw new NotImplementedException();
        }

        IResult IColorService.Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
