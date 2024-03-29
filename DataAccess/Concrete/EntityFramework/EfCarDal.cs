﻿using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarsDBContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsDBContext context=new CarsDBContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 ColorName = cl.Name,
                                 BrandName = b.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear=c.ModelYear,
                                 Description=c.Description

                             };
                return result.ToList();

            }
        }
    }

   
}
