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
            /// The service type of the IP address pool.
            /// 
            /// *   **CloudBox** Only cloud box users can select this type.
            /// *   **Default** (default)
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The status of the IP address pool.
            /// 
            /// *   **Normal**
            /// *   **FinancialLocked**
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The time when the IP address pool was created. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the IP address pool.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether idle IP addresses exist.
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IpAddressRemaining")]
            [Validation(Required=false)]
            public bool? IpAddressRemaining { get; set; }

            /// <summary>
            /// The line type.
            /// 
            /// *   **BGP**: BGP (Multi-ISP)
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro
            /// 
            /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](https://help.aliyun.com/document_detail/32321.html).
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
            /// The region ID of the IP address pool.
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
            /// The edition of Anti-DDoS.
            /// 
            /// *   If you do not set this parameter, Anti-DDoS Origin Basic is used.
            /// *   If the value is set to **AntiDDoS_Enhanced**, Anti-DDoS Pro/Premium is used.
            /// </summary>
            [NameInMap("SecurityProtectionTypes")]
            [Validation(Required=false)]
            public List<string> SecurityProtectionTypes { get; set; }

            /// <summary>
            /// The sharing type of the IP address pool.
            /// 
            /// *   If **Shared** is returned, the IP address pool is shared.
            /// *   If an empty value is returned, the IP address pool is not shared.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The status of the IP address pool.
            /// 
            /// *   **Created**
            /// *   **Deleting**
            /// *   **Modifying**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag list.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags> Tags { get; set; }
            public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags : TeaModel {
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
            /// The total number of available IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// The number of used IP addresses in the public IP address pool.
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

            /// <summary>
            /// The user type. Valid values:
            /// 
            /// *   **admin**: An administrator can delete, modify, and query IP address pools, and can assign elastic IP addresses (EIPs) to the pool.
            /// *   **user**: A user can only assign EIPs to the IP address pool and query the IP address pool, but cannot modify or delete the IP address pool.
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            /// <summary>
            /// The zone of the IP address pool. This parameter is returned only when the service type of the IP address pool is CloudBox.
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
