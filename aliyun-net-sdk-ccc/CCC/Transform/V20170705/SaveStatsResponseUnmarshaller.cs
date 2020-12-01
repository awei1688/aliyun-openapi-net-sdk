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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class SaveStatsResponseUnmarshaller
    {
        public static SaveStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveStatsResponse saveStatsResponse = new SaveStatsResponse();

			saveStatsResponse.HttpResponse = _ctx.HttpResponse;
			saveStatsResponse.RequestId = _ctx.StringValue("SaveStats.RequestId");
			saveStatsResponse.Success = _ctx.BooleanValue("SaveStats.Success");
			saveStatsResponse.Code = _ctx.StringValue("SaveStats.Code");
			saveStatsResponse.Message = _ctx.StringValue("SaveStats.Message");
			saveStatsResponse.HttpStatusCode = _ctx.IntegerValue("SaveStats.HttpStatusCode");
			saveStatsResponse.RowCount = _ctx.LongValue("SaveStats.RowCount");
        
			return saveStatsResponse;
        }
    }
}
