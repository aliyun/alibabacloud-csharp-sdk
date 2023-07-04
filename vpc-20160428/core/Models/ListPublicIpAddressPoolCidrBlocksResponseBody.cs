// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolCidrBlocksResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** was not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value is the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PublicIpPoolCidrBlockList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolCidrBlocksResponseBodyPublicIpPoolCidrBlockList> PublicIpPoolCidrBlockList { get; set; }
        public class ListPublicIpAddressPoolCidrBlocksResponseBodyPublicIpPoolCidrBlockList : TeaModel {
            /// <summary>
            /// The ID of the IP address pool.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The CIDR blocks.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The information about the CIDR blocks.
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

            /// <summary>
            /// The time when the CIDR block was created. The time is displayed in `YYYY-MM-DDThh:mm:ssZ` format.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The total number of available IP addresses in the CIDR block.
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// The status of the CIDR block in the IP address pool. Valid values:
            /// 
            /// *   **Created**: available
            /// *   **Deleting**: being deleted
            /// *   **Modifying**: being modified
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum number of entries returned. Valid values: **10** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
