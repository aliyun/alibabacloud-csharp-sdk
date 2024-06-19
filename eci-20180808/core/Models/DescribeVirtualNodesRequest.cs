// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeVirtualNodesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotency of requests?](https://help.aliyun.com/document_detail/25693.html)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The maximum number of resources that are allowed to return for this request. Default value: 20. Maximum value: 20.
        /// 
        /// >  The number of returned resources is less than or equal to the specified number.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. If this parameter is empty, all results have been returned.
        /// 
        /// You do not need to specify this parameter in the first request. From the second request, you can obtain the token from the result returned by the previous request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the virtual nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The status of the virtual node. Valid values:
        /// 
        /// *   Pending
        /// *   Ready
        /// *   Failed
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags that are bound to the virtual node.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVirtualNodesRequestTag> Tag { get; set; }
        public class DescribeVirtualNodesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The IDs of the virtual nodes. You can specify up to 20 IDs. Each ID must be a string in the JSON format.
        /// </summary>
        [NameInMap("VirtualNodeIds")]
        [Validation(Required=false)]
        public string VirtualNodeIds { get; set; }

        /// <summary>
        /// The names of the virtual nodes.
        /// </summary>
        [NameInMap("VirtualNodeName")]
        [Validation(Required=false)]
        public string VirtualNodeName { get; set; }

    }

}
