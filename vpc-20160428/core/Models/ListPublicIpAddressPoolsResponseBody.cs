// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is used to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The IP address pools.
        /// </summary>
        [NameInMap("PublicIpAddressPoolList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList> PublicIpAddressPoolList { get; set; }
        public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList : TeaModel {
            /// <summary>
            /// The service type of the IP address pool. Valid values:
            /// 
            /// *   **CloudBox**: the cloud box service type. Only cloud box users can select this type.
            /// *   **Default** (default): the general service type.
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The time when the IP address pool was created. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The information about the IP address pool.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the IP address pool has idle IP addresses. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IpAddressRemaining")]
            [Validation(Required=false)]
            public bool? IpAddressRemaining { get; set; }

            /// <summary>
            /// The line type. Valid values:
            /// 
            /// *   **BGP**: BGP (Multi-ISP) line
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro line
            /// 
            /// For more information about the BGP (Multi-ISP) line and BGP (Multi-ISP) Pro line, see the "Line types" section of [What is EIP?](~~32321~~)
            /// 
            /// If you are allowed to use single-ISP bandwidth, one of the following values may be returned:
            /// 
            /// *   **ChinaTelecom**
            /// *   **ChinaUnicom**
            /// *   **ChinaMobile**
            /// *   **ChinaTelecom_L2**
            /// *   **ChinaUnicom_L2**
            /// *   **ChinaMobile_L2**
            /// 
            /// If your services are deployed in China East 1 Finance, **BGP_FinanceCloud** is returned.
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The name of the IP address pool.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud account to which the IP address pool belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// The ID of the IP address pool.
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

            /// <summary>
            /// The ID of the region in which the IP address pool that you want to query resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the IP address pool belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the IP address pool is shared.
            /// 
            /// *   Only **Shared** may be returned.
            /// *   An empty value indicates that the IP address pool is not shared.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The status of the IP address pool. Valid values:
            /// 
            /// *   **Created**
            /// *   **Deleting**
            /// *   **Modifying**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags> Tags { get; set; }
            public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The total number of IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// The number of occupied IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

            /// <summary>
            /// The user type. Valid values:
            /// 
            /// *   **admin**: administrator. An administrator can delete, modify, and query IP address pools and allocate elastic IP addresses (EIPs) to IP address pools.
            /// *   **user**: regular user. A regular user can only allocate EIPs to IP address pools and query IP address pools. A regular user cannot modify or delete IP address pools.
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public bool? UserType { get; set; }

            /// <summary>
            /// The zones of the IP address pool. This parameter is returned only when BizType is set to CloudBox.
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

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
        public int? TotalCount { get; set; }

    }

}
