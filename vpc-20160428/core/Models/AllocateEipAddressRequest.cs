// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressRequest : TeaModel {
        /// <summary>
        /// The billing cycle of the subscription EIP. Valid values:
        /// 
        /// *   **Month** (default): The EIP is billed on a monthly basis.
        /// *   **Year**: The EIP is billed on an annual basis.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, this parameter is required. When **InstanceChargeType** is set to **PostPaid**, this parameter is not required.
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The metering method of the EIP. Valid values:
        /// 
        /// *   **PayByBandwidth** (default): pay-by-bandwidth
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, you must set **InternetChargeType** to **PayByBandwidth**.
        /// 
        /// When **InstanceChargeType** is set to **PostPaid**, set **InternetChargeType** to **PayByBandwidth** or **PayByTraffic**.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The promotion code. Ignore this parameter.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The edition of Anti-DDoS.
        /// 
        /// *   If you do not set this parameter, Anti-DDoS Origin Basic is used by default.
        /// *   If you set the value to **AntiDDoS_Enhanced**, Anti-DDoS Pro/Premium is used.
        /// 
        /// You can set up to 10 editions of Anti-DDoS.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: false. Valid values:
        /// 
        /// *   **false**: disables automatic payment. This is the default value. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, this parameter is required. When **InstanceChargeType** is set to **PostPaid**, this parameter is not required.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the EIP.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
        /// 
        /// >  This parameter is unavailable when you create a subscription EIP.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The ID of the IP address pool.
        /// 
        /// The EIP is allocated from the IP address pool.
        /// 
        /// You cannot use the IP address pool feature by default. To use the IP address pool feature, apply for the privilege in the Quota Center console. For more information, see [Request a quota increase in the Quota Center console](~~108213~~).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The billing method of the EIP. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid** (default): pay-as-you-go
        /// 
        /// When **InstanceChargeType** is set to **PrePaid**, set **InternetChargeType** to **PayByBandwidth**. When **InstanceChargeType** is set to **PostPaid**, set **InternetChargeType** to **PayByBandwidth** or **PayByTraffic**.
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
        /// The network type. Set the value to **public**, which specifies the Internet.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the resource group. This parameter is returned only when **InstanceChargeType** is set to **PostPaid**.
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

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
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The description of the EIP.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// 
        /// >  This parameter is unavailable when you create a subscription EIP.
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

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
