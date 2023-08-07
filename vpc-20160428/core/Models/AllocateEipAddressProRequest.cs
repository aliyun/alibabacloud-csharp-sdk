// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressProRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false**: disables automatic payment. After an order is generated, you must go to the Order Center to complete the payment.
        /// *   **true**: enabled. Payments are automatically completed.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, this parameter is required. When **InstanceChargeType** is set to **PostPaid**, this parameter is not required.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The maximum bandwidth of the specified EIP. Unit: Mbit/s.
        /// 
        /// *   When **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByBandwidth**, valid values for **Bandwidth** are **1** to **500**.
        /// *   When **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByTraffic**, valid values for **Bandwidth** are **1** to **200**.
        /// *   When **InstanceChargeType** is set to **PrePaid**, valid values for **Bandwidth** are **1** to **1000**.
        /// 
        /// Default value: **5**. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines All regions support BGP (Multi-ISP) EIPs.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).
        /// 
        /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](~~32321~~).
        /// 
        /// *   If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        ///     *   **ChinaTelecom**: China Telecom
        ///     *   **ChinaUnicom**: China Unicom
        ///     *   **ChinaMobile**: China Mobile
        ///     *   **ChinaTelecom_L2**: China Telecom L2
        ///     *   **ChinaUnicom_L2**: China Unicom L2
        ///     *   **ChinaMobile_L2**: China Mobile L2
        /// 
        /// *   If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The billing method of the specified EIP. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid** (default): pay-as-you-go
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, you must set **InternetChargeType** to **PayByBandwidth**.
        /// 
        /// When **InstanceChargeType** is set to **PostPaid**, you must set **InternetChargeType** to **PayByBandwidth** or **PayByTraffic**.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of the EIP.
        /// 
        /// Set **IpAddress** or **InstanceId**. If you leave both parameters empty, the system randomly allocates an EIP.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metering method of the specified EIP. Valid values:
        /// 
        /// *   **PayByBandwidth** (default): pay-by-bandwidth
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, you must set **InternetChargeType** to **PayByBandwidth**.
        /// 
        /// When **InstanceChargeType** is set to **PostPaid**, you must set **InternetChargeType** to **PayByBandwidth** or **PayByTraffic**.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The IP address of the EIP that you want to request.
        /// 
        /// Set **IpAddress** or **InstanceId**. If you leave both parameters empty, the system randomly allocates an EIP.
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The network type. Set the value to **public**, which specifies the Internet.
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
        /// The subscription duration of the bandwidth plan.
        /// 
        /// *   If **PricingCycle** is set to **Month**, set **Period** to a value from **1 to 9**.
        /// *   If **PricingCycle** is set to **Year**, set **Period** to a value from **1 to 3**.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, this parameter is required.
        /// 
        /// Ignore this parameter when **InstanceChargeType** is set to **PostPaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The billing cycle of the subscription EIP. Valid values:
        /// 
        /// *   **Month** (default): The EIP is billed on a monthly basis.
        /// *   **Year**: The EIP is billed on an annual basis.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, this parameter is required. When **InstanceChargeType** is set to **PostPaid**, this parameter is not required.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the IP address pool.
        /// 
        /// The EIP is allocated from the IP address pool.
        /// 
        /// You cannot use the IP address pool feature by default. To use this feature, apply for the privilege in the Quota Center console. For more information, see [Request a quota increase in the Quota Center console](~~108213~~).
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// The ID of the region where you want to request a specified EIP.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the EIP belongs.
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

        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

    }

}
