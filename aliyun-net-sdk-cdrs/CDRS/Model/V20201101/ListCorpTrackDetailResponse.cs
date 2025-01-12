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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListCorpTrackDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string success;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListCorpTrackDetail_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<ListCorpTrackDetail_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListCorpTrackDetail_DataItem
		{

			private string date;

			private string lastTime;

			private string startTime;

			private string endSourceImage;

			private string deviceId;

			private string startTargetImage;

			private string groupId;

			private string personId;

			private string startSourceImage;

			private string corpId;

			private string endTargetImage;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public string LastTime
			{
				get
				{
					return lastTime;
				}
				set	
				{
					lastTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndSourceImage
			{
				get
				{
					return endSourceImage;
				}
				set	
				{
					endSourceImage = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string StartTargetImage
			{
				get
				{
					return startTargetImage;
				}
				set	
				{
					startTargetImage = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
				}
			}

			public string StartSourceImage
			{
				get
				{
					return startSourceImage;
				}
				set	
				{
					startSourceImage = value;
				}
			}

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			public string EndTargetImage
			{
				get
				{
					return endTargetImage;
				}
				set	
				{
					endTargetImage = value;
				}
			}
		}
	}
}
