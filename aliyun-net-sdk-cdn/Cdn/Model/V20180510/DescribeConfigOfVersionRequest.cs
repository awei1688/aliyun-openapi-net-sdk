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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class DescribeConfigOfVersionRequest : RpcAcsRequest<DescribeConfigOfVersionResponse>
    {
        public DescribeConfigOfVersionRequest()
            : base("Cdn", "2018-05-10", "DescribeConfigOfVersion")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string versionId;

		private string securityToken;

		private string functionName;

		private long? groupId;

		private long? ownerId;

		private int? functionId;

		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
				DictionaryUtil.Add(QueryParameters, "VersionId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string FunctionName
		{
			get
			{
				return functionName;
			}
			set	
			{
				functionName = value;
				DictionaryUtil.Add(QueryParameters, "FunctionName", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? FunctionId
		{
			get
			{
				return functionId;
			}
			set	
			{
				functionId = value;
				DictionaryUtil.Add(QueryParameters, "FunctionId", value.ToString());
			}
		}

        public override DescribeConfigOfVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeConfigOfVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
