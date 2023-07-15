﻿using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length <= 2)
            {
                return new ErrorResult(Message.ColorNameInValid);
            }

            _colorDal.Add(color);
            return new SuccessResult(Message.AddedColor);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Message.DeletedColor);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == colorId));
        }

        public IResult Update(Color color)
        {
            if (color.ColorName.Length <= 2)
            {
                return new ErrorResult(Message.ColorNameInValid);
            }

            _colorDal.Update(color);
            return new SuccessResult(Message.UpdatedColor);
        }
    }
}