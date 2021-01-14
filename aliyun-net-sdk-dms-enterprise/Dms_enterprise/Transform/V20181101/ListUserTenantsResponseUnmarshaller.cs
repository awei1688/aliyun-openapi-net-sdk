/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListUserTenantsResponseUnmarshaller
    {
        public static ListUserTenantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserTenantsResponse listUserTenantsResponse = new ListUserTenantsResponse();

			listUserTenantsResponse.HttpResponse = _ctx.HttpResponse;
			listUserTenantsResponse.RequestId = _ctx.StringValue("ListUserTenants.RequestId");
			listUserTenantsResponse.Success = _ctx.BooleanValue("ListUserTenants.Success");
			listUserTenantsResponse.ErrorMessage = _ctx.StringValue("ListUserTenants.ErrorMessage");
			listUserTenantsResponse.ErrorCode = _ctx.StringValue("ListUserTenants.ErrorCode");

			List<ListUserTenantsResponse.ListUserTenants_Tenant> listUserTenantsResponse_tenantList = new List<ListUserTenantsResponse.ListUserTenants_Tenant>();
			for (int i = 0; i < _ctx.Length("ListUserTenants.TenantList.Length"); i++) {
				ListUserTenantsResponse.ListUserTenants_Tenant tenant = new ListUserTenantsResponse.ListUserTenants_Tenant();
				tenant.Tid = _ctx.LongValue("ListUserTenants.TenantList["+ i +"].Tid");
				tenant.TenantName = _ctx.StringValue("ListUserTenants.TenantList["+ i +"].TenantName");
				tenant.Status = _ctx.StringValue("ListUserTenants.TenantList["+ i +"].Status");

				listUserTenantsResponse_tenantList.Add(tenant);
			}
			listUserTenantsResponse.TenantList = listUserTenantsResponse_tenantList;
        
			return listUserTenantsResponse;
        }
    }
}
