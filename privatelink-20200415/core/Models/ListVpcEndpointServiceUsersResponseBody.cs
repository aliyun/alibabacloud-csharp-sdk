// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceUsersResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next requests are performed.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The whitelists in the format of Aliyun Resource Name (ARN).
        /// </summary>
        [NameInMap("UserARNs")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceUsersResponseBodyUserARNs> UserARNs { get; set; }
        public class ListVpcEndpointServiceUsersResponseBodyUserARNs : TeaModel {
            /// <summary>
            /// The whitelist in the format of ARN.
            /// </summary>
            [NameInMap("UserARN")]
            [Validation(Required=false)]
            public string UserARN { get; set; }

        }

        /// <summary>
        /// The Alibaba Cloud accounts in the whitelist of the endpoint service.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceUsersResponseBodyUsers> Users { get; set; }
        public class ListVpcEndpointServiceUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account in the whitelist of the endpoint service.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
