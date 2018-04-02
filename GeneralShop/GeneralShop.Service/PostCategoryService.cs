using GeneralShop.Data.Infrastructure;
using GeneralShop.Data.Respositories;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Service
{

    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        void Save();
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllParentById(int parentId);
        PostCategory GetById(int id);

    }
    class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRespostory;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRespostory = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public PostCategory Add(PostCategory postCategory)
        {
           return _postCategoryRespostory.Add(postCategory);
                    }


        public PostCategory Delete(int id)
        {
          return  _postCategoryRespostory.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRespostory.GetAll();
        }

        public IEnumerable<PostCategory> GetAllParentById(int parentId)
        {
           return _postCategoryRespostory.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRespostory.GetSingleById(id); 
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRespostory.Update(postCategory);
        }
    }
}
