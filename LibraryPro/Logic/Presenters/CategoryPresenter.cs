using Library.Models;
using Library.Views.Interface;
using LibraryPro.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPro.Logic.Presenters
{
    class CategoryPresenter
    {
        IbookCategory icategory;
        CategoryModel catModel = new CategoryModel();
        public CategoryPresenter(IbookCategory View)
        {
            this.icategory = View;
        }
        //connect between model cat and interface cat
        private void connectBetweenModelInterface()
        {
            catModel.Id = icategory.Id;
            catModel.CatName =icategory. CatName;
        }
        public bool CatInsert()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryInsert(catModel.Id, catModel.CatName);
        }
    }
}
