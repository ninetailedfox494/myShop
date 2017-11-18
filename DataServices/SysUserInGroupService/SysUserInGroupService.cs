﻿using DataModel.PagingModel;
using DataModel.SysUserInGroupModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.SysUserInGroupService
{
    public class SysUserInGroupService
    {
        private readonly UnitOfWork.UnitOfWork _uow = new UnitOfWork.UnitOfWork();

        /*==GetAll  ==*/
        public List<SysUserInGroupModel> GetAll(PagingModel _params)
        {
            var data = _uow.SysUserInGroupRepo.SQLQuery<SysUserInGroupModel>("exec sp_SysUserInGroup_GetAll " +
                  "@PageNumber," +
                  "@PageSize" 
                  ,
                  new SqlParameter("PageNumber", SqlDbType.Int)
                  {
                      Value = _params.PageNumber
                  },
                  new SqlParameter("PageSize", SqlDbType.Int)
                  {
                      Value = _params.PageSize
                  }).ToList();
            return data;
        }

        /*==GetAllById  ==*/
        public SysUserInGroupModel GetById(SysUserInGroupModel _params)
        {
            var data = _uow.SysUserInGroupRepo.SQLQuery<SysUserInGroupModel>("sp_SysUserInGroup_GetById "
                + "@SysUserInGroupId",
                new SqlParameter("SysUserInGroupId", SqlDbType.Int)
                {
                    Value = _params.SysUserInGroupId
                }).FirstOrDefault();
            return data;
        }

        /*===Insert===*/
        public void Insert(SysUserInGroupModel _params)
        {
            try
            {
                _uow.SysUserInGroupRepo.ExcQuery("exec sp_SysUserInGroup_Insert " +
                    "@GroupRolesId," +
                    "@UserId," +
                    "@Descriptions," +
                    "@Display_Order," +
                    "@Is_Active," +
                    "@CreateDate," +
                    "@CreateBy," +
                    "@UpdateDate," +
                    "@UpdateBy",
                    new SqlParameter("GroupRolesId", SqlDbType.Int)
                    {
                        Value = _params.GroupRolesId
                    },
                    new SqlParameter("UserId", SqlDbType.Int)
                    {
                        Value = _params.UserId
                    },
                    new SqlParameter("Descriptions", SqlDbType.NVarChar)
                    {
                        Value = _params.Descriptions ?? DBNull.Value.ToString()
                    },
                    new SqlParameter("Display_Order", SqlDbType.Int)
                    {
                        Value = _params.Display_Order ?? 1
                    },
                    new SqlParameter("Is_Active", SqlDbType.Bit)
                    {
                        Value = _params.Is_Active == null ? true : _params.Is_Active
                    },
                    new SqlParameter("CreateDate", SqlDbType.Date)
                    {
                        Value = _params.CreateDate == null ? DateTime.Now : _params.CreateDate
                    },
                    new SqlParameter("CreateBy", SqlDbType.Int)
                    {
                        Value = _params.CreateBy ?? 1
                    },
                    new SqlParameter("UpdateDate", SqlDbType.Date)
                    {
                        Value = _params.UpdateDate == null ? DateTime.Now : _params.UpdateDate
                    },
                    new SqlParameter("UpdateBy", SqlDbType.Int)
                    {
                        Value = _params.UpdateBy ?? 1
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình thêm mới " + ex.Message);
            }
        }

        /*===Update===*/
        public void Update(SysUserInGroupModel _params)
        {
            try
            {
                _uow.SysUserInGroupRepo.ExcQuery("exec sp_SysUserInGroup_Update " +
                    "@SysUserInGroupId," +
                    "@GroupRolesId," +
                    "@UserId," +
                    "@Descriptions," +
                    "@Display_Order," +
                    "@Is_Active," +
                    "@CreateDate," +
                    "@CreateBy," +
                    "@UpdateDate," +
                    "@UpdateBy",
                    new SqlParameter("SysUserInGroupId", SqlDbType.Int)
                    {
                        Value = _params.SysUserInGroupId
                    },
                    new SqlParameter("GroupRolesId", SqlDbType.Int)
                    {
                        Value = _params.GroupRolesId
                    },
                    new SqlParameter("UserId", SqlDbType.Int)
                    {
                        Value = _params.UserId
                    },
                    new SqlParameter("Descriptions", SqlDbType.NVarChar)
                    {
                        Value = _params.Descriptions ?? DBNull.Value.ToString()
                    },
                    new SqlParameter("Display_Order", SqlDbType.Int)
                    {
                        Value = _params.Display_Order ?? 1
                    },
                    new SqlParameter("Is_Active", SqlDbType.Bit)
                    {
                        Value = _params.Is_Active == null ? true : _params.Is_Active
                    },
                    new SqlParameter("CreateDate", SqlDbType.Date)
                    {
                        Value = _params.CreateDate == null ? DateTime.Now : _params.CreateDate
                    },
                    new SqlParameter("CreateBy", SqlDbType.Int)
                    {
                        Value = _params.CreateBy ?? 1
                    },
                    new SqlParameter("UpdateDate", SqlDbType.Date)
                    {
                        Value = _params.UpdateDate == null ? DateTime.Now : _params.UpdateDate
                    },
                    new SqlParameter("UpdateBy", SqlDbType.Int)
                    {
                        Value = _params.UpdateBy ?? 1
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình cập nhập" + ex.Message);
            }
        }

        /*===Delete===*/
        public void Delete(SysUserInGroupModel _params)
        {
            try
            {
                _uow.SysUserInGroupRepo.ExcQuery("exec sp_SysUserInGroup_Update " +
                    "@SysUserInGroupId" ,
                    new SqlParameter("SysUserInGroupId", SqlDbType.Int)
                    {
                        Value = _params.SysUserInGroupId
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình xóa" + ex.Message);
            }
        }
    }
}
