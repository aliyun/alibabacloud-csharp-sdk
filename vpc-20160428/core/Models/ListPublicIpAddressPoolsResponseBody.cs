// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If **NextToken** is returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PublicIpAddressPoolList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList> PublicIpAddressPoolList { get; set; }
        public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList : TeaModel {
            /// <summary>
            /// The region ID of the IP address pool.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The status of the IP address pool. Valid values:
            /// 
            /// *   **Created**: The IP address pool is available.
            /// *   **Deleting**: The IP address pool is being deleted.
            /// *   **Modifying**: The IP address pool is being modified.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The number of occupied IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("IpAddressRemaining")]
            [Validation(Required=false)]
            public bool? IpAddressRemaining { get; set; }

            /// <summary>
            /// The time when the IP address pool was created. The time is displayed in `YYYY-MM-DDThh:mm:ssZ` format.
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The line type.
            /// 
            /// *   **BGP**: BGP (Multi-ISP) lines
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines
            /// 
            /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](~~32321~~).
            /// 
            /// If you are allowed to use single-ISP bandwidth, one of the following values is returned:
            /// 
            /// *   **ChinaTelecom**: China Telecom
            /// *   **ChinaUnicom**: China Unicom
            /// *   **ChinaMobile**: China Mobile
            /// *   **ChinaTelecom_L2**: China Telecom L2
            /// *   **ChinaUnicom_L2**: China Unicom L2
            /// *   **ChinaMobile_L2**: China Mobile L2
            /// 
            /// If your services are deployed in China East 1 Finance, **BGP_FinanceCloud** is returned.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the IP address pool has idle IP addresses. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// The list of IP address pools.
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

            /// <summary>
            /// The ID of the IP address pool.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the IP address pool is shared.
            /// 
            /// *   **Shared**: The IP address pool is shared.
            /// *   An empty value indicates that the IP address pool is not shared.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account to which the IP address pool belongs.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The name of the IP address pool.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the resource group to which the IP address pool belongs.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags> Tags { get; set; }
            public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags : TeaModel {
                /// <summary>
                /// The list of tags.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the IP address pool.
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// The total number of IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public bool? UserType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
