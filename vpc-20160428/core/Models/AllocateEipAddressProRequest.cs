// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressProRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// 
        /// *   **false**: Automatic payment is disabled. After an order is generated, you must go to the Order Center to complete the payment.
        /// *   **true**: Automatic payment is enabled. After an order is generated, the payment is automatically completed.
        /// 
        /// This parameter is required if **InstanceChargeType** is set to **PrePaid**. This parameter is optional if **InstanceChargeType** is set to **PostPaid**.
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
        /// Default value: **5** Mbit /s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) line The BGP (Multi-ISP) line is supported in all regions.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro line The BGP (Multi-ISP) Pro line is supported in the China (Hong Kong), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.
        /// 
        /// For more information about the BGP (Multi-ISP) line and BGP (Multi-ISP) Pro line, see the "Line types" section of [What is EIP?](~~32321~~)
        /// 
        /// *   If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        ///     *   **ChinaTelecom**
        ///     *   **ChinaUnicom**
        ///     *   **ChinaMobile**
        ///     *   **ChinaTelecom_L2**
        ///     *   **ChinaUnicom_L2**
        ///     *   **ChinaMobile_L2**
        /// 
        /// *   If your services are deployed in China East 1 Finance, this parameter is required and you must set the parameter to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The billing method of the EIP. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid** (default): pay-as-you-go
        /// 
        /// Set the value of **InternetChargeType** to **PayByBandwidth** if **InstanceChargeType** is set to **PrePaid**.
        /// 
        /// Valid values when **InstanceChargeType** is set to **PostPaid**: **PayByBandwidth** or **PayByTraffic**.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The EIP ID.
        /// 
        /// Specify **IpAddress** or **InstanceId**. If you leave both parameters empty, the system randomly allocates an EIP.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metering method of the EIP. Valid values:
        /// 
        /// *   **PayByBandwidth** (default): pay-by-bandwidth.
        /// *   **PayByTraffic**: pay-by-data-transfer.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, you must set **InternetChargeType** to **PayByBandwidth**.
        /// 
        /// When **InstanceChargeType** is set to **PostPaid**, set **InternetChargeType** to **PayByBandwidth** or **PayByTraffic**.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The IP address of the EIP.
        /// 
        /// Specify **IpAddress** or **InstanceId**. If you leave both parameters empty, the system randomly allocates an EIP.
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The network type. By default, this value is set to **public**, which specifies the public network type.
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
        /// The subscription duration.
        /// 
        /// *   Valid values when **PricingCycle** is set to **Month**: **1 to 9**.****
        /// *   Valid values when **PricingCycle** is set to **Year**: **1 to 3**.****
        /// 
        /// This parameter is required if **InstanceChargeType** is set to **PrePaid**.
        /// 
        /// Leave this parameter empty if **InstanceChargeType** is set to **PostPaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The billing cycle of the subscription EIP. Valid values:
        /// 
        /// *   **Month** (default)
        /// *   **Year**
        /// 
        /// This parameter is required if **InstanceChargeType** is set to **PrePaid**. This parameter is optional if **InstanceChargeType** is set to **PostPaid**.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the IP address pool.
        /// 
        /// The EIP is allocated from the IP address pool.
        /// 
        /// By default, you cannot use the IP address pool. To use this feature, apply for the privilege in the Quota Center console. For more information, see the "Request a quota increase in the Quota Center console" section of [Manage EIP quotas](~~108213~~).
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// The ID of the region to which the EIP belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
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

        /// <summary>
        /// The editions of Anti-DDoS.
        /// 
        /// *   If you do not specify this parameter, Anti-DDoS Origin Basic is used.
        /// *   If you set the parameter to **AntiDDoS_Enhanced**, Anti-DDoS Pro/Premium is used.
        /// 
        /// You can configure Anti-DDoS editions for up to 10 EIPs.
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

    }

}
