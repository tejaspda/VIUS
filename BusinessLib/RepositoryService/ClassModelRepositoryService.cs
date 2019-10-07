using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLib.Entity;
using BusinessLib.Interface;
using BusinessLib.Common;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLib.Model
{
    public class ClassModelRepositoryService : IRepository
    {
        private List<ClassEntity> _clsEntitys;
        public ClassModelRepositoryService()
        {
            if (_clsEntitys == null)
            {
                InitializeRepository();
            }

        }

        private void InitializeRepository()
        {

            _clsEntitys = new List<ClassEntity> {

                new ClassEntity
            { Id=1,Name="Harry Poter"},
                new ClassEntity
            { Id=2, Name="Nuts Overloaded"}
            };


        }


        public async Task<ActionResult> GetStates()
        {
            APIWrapper client = new APIWrapper();
            string relativePath = "api/Admin/GetStates";
            return await client.ApiGet(relativePath);

            //return await relativePath;
        }
    
        public ClassEntity GetSample(int id)
        {

           // var t = 
           // var result = await t;
            return _clsEntitys.Find(x => x.Id == id); ;
        }

        public  IList<ClassEntity> GetAllSample()
        {
            return  _clsEntitys;
        }

    }

   



}
