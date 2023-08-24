// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than **0** and less than or equal to the maximum value supported by the integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The minor version of the node.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeRoleZoneInfo**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The current bandwidth of the node, which consists of the default bandwidth and the increased bandwidth. Unit: MB/s.
        /// 
        /// > 
        /// *   You can call the [EnableAdditionalBandwidth](~~206173~~) operation to specify the increased bandwidth.
        /// *   You can also use this parameter to calculate the increased bandwidth. For example, if the default bandwidth of the node is 96 MB/s and the returned value of this parameter is 100, the increased bandwidth is 4 MB/s.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public int? QueryType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
