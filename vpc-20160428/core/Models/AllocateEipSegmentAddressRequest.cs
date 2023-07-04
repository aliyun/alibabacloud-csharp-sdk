// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressRequest : TeaModel {
        /// <summary>
        /// The subnet mask length of the contiguous EIPs. Valid values:
        /// 
        /// - **28**: applies for 16 contiguous EIPs in each call.
        /// - **27**: applies for 32 contiguous EIPs in each call.
        /// - **26**: applies for 64 contiguous EIPs each call.
        /// - **25**: applies for 128 contiguous EIPs in each call.
        /// - **24**: applies for 256 contiguous EIPs in each call.
        /// 
        /// >  The number of contiguous EIPs allocated by the system may be less than the requested number because one, three, or four EIPs may be reserved.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The maximum bandwidth of the EIP. Unit: Mbit/s.
        /// 
        /// *   When **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByBandwidth**, the valid values for **Bandwidth** are **1** to **500**.
        /// *   When **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByTraffic**, the valid values for **Bandwidth** are **1** to **200**.
        /// *   When **InstanceChargeType** is set to **PrePaid**, the valid values for **Bandwidth** are **1** to **1000**.
        /// 
        /// Default value: **5**. Unit: Mbit/s.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The metering method of the contiguous EIPs. Valid values:
        /// 
        /// *   **PayByBandwidth** (default): pay-by-bandwidth
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// </summary>
        [NameInMap("EipMask")]
        [Validation(Required=false)]
        public string EipMask { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines All regions support BGP (Multi-ISP) EIPs.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).
        /// 
        /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](~~32321~~).
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        /// *   **ChinaTelecom**: China Telecom
        /// *   **ChinaUnicom**: China Unicom
        /// *   **ChinaMobile**: China Mobile
        /// *   **ChinaTelecom_L2**: China Telecom L2
        /// *   **ChinaUnicom_L2**: China Unicom L2
        /// *   **ChinaMobile_L2**: China Mobile L2
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The ID of the contiguous EIP group.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("Netmode")]
        [Validation(Required=false)]
        public string Netmode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Set the value to **public**, which specifies the Internet.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
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

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
