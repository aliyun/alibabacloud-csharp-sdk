// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceUsersRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Valid values: **1 to 50**. Default value: **50**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If this is your first request and no next requests are to be performed, you do not need to specify this parameter.
        /// *   If a next request is to be performed, set the value to the value of **NextToken** that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the endpoint service that you want to query.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/120468.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The endpoint service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account in the whitelist of the endpoint service.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// The type of the user list in the whitelist of the endpoint service.
        /// </summary>
        [NameInMap("UserListType")]
        [Validation(Required=false)]
        public string UserListType { get; set; }

    }

}
