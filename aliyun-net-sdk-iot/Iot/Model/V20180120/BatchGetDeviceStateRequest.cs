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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class BatchGetDeviceStateRequest : RpcAcsRequest<BatchGetDeviceStateResponse>
    {
        public BatchGetDeviceStateRequest()
            : base("Iot", "2018-01-20", "BatchGetDeviceState", "iot", "openAPI")
        {
        }

		private List<string> iotIds;

		private string iotInstanceId;

		private List<string> deviceNames;

		private string productKey;

		private string accessKeyId;

		public List<string> IotIds
		{
			get
			{
				return iotIds;
			}

			set
			{
				iotIds = value;
				for (int i = 0; i < iotIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IotId." + (i + 1) , iotIds[i]);
				}
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public List<string> DeviceNames
		{
			get
			{
				return deviceNames;
			}

			set
			{
				deviceNames = value;
				for (int i = 0; i < deviceNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeviceName." + (i + 1) , deviceNames[i]);
				}
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override BatchGetDeviceStateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BatchGetDeviceStateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}