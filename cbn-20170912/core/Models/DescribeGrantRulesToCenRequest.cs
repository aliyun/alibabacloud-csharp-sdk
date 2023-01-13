// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**.  
        /// 
        /// - If you do not set **MaxResults**, it indicates that you do not need to query results in batches. The value of **MaxResults** in the response indicates the total number of entries.
        /// - If a value is specified for **MaxResults**, it indicates that you need to query results in batches. The value of **MaxResults** in the response indicates the number of entries in the current batch. We recommend that you set **MaxResults** to **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// - If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// - If a subsequent query is to be sent, set the value to the value of **NextToken** that was returned from the last call.
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
        /// - **VPC**: virtual private cloud (VPC)
        /// - **VBR**: virtual border router (VBR)
        /// - **CCN**: Cloud Connect Network (CCN) instance
        /// - **VPN**: IPsec-VPN connection
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The ID of the region where the network instance is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
