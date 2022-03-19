﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;

namespace Business.BusinessAspects.AutoFac
{

    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// parametre olarak girilen roles değişkenini Split aracılığıyla parantezin içindeki karakterle ayırma
        /// </summary>
        /// <param name="roles"></param>
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(",");
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var item in _roles)
            {
                if (roleClaims.Contains(item))
                {
                    return;
                }
            }

            throw new Exception("Yetkiniz yok");
        }
    }
}
//2 haftaya görüşmek üzere 19.03.2022 , 23.43
//e's
