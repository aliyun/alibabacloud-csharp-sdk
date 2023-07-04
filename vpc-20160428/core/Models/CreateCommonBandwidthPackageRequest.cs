// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCommonBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// The billing method of the EIP bandwidth plan. Set the value to **PayByTraffic**, which refers to the pay-by-data-transfer metering method.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The maximum bandwidth of the EIP bandwidth plan.
        /// 
        /// Valid values: **1** to **1000**. Unit: Mbit/s.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The description of the EIP bandwidth plan.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The ID of the EIP bandwidth plan.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically sets the **ClientToken** parameter to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The edition of Anti-DDoS.
        /// 
        /// *   If you do not set this parameter, Anti-DDoS Origin Basic is used.
        /// *   If you set the value to **AntiDDoS_Enhanced**, Anti-DDoS Pro/Premium is used.
        /// 
        /// Valid values of **N**: **1** to **10**. You can specify only one Anti-DDoS edition. If you specify more than one edition, the operation may fail.
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP**: BGP (Multi-ISP) lines. BGP (Multi-ISP) lines are available in all regions.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. BGP (Multi-ISP) Pro is available only in the China (Hong Kong), Singapore, Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions.
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
        /// If your services are deployed in China East 1 Finance, you must set this parameter to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The percentage of the minimum bandwidth commitment. Set the parameter to **20**.
        /// 
        /// >  This parameter is available only on the Alibaba Cloud China site.
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

        /// <summary>
        /// The name of the EIP bandwidth plan.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
