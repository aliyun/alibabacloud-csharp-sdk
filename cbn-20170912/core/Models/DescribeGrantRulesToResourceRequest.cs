// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToResourceRequest : TeaModel {
        /// <summary>
        /// *   If you do not set **MaxResults**, it indicates that you do not need to query results in batches. The value of **MaxResults** indicates the total number of entries.
        /// *   If you specify a value for **MaxResults**, it indicates that you need to query results in batches. The value of **MaxResults** indicates the number of entries to return in each batch. Valid values: **1** to **100**. The value of **MaxResults** in the response indicates the number of entries in the current batch. We recommend that you set **MaxResults** to **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of the **NextToken** parameter.
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
        /// The type of the network instance. Valid values:
        /// 
        /// *   **VPC**: virtual private cloud (VPC)
        /// *   **ExpressConnect**: virtual border router (VBR)
        /// *   **VPN**: IPsec-VPN connection
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The region ID of the network instance.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The network instance ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
