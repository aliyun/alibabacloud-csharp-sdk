// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCommonBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// The maximum bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.
        /// 
        /// Valid values: **1** to **1000**. Default value: **1**.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the **client token**. The value of **RequestId** is different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the Internet Shared Bandwidth instance.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP**: BGP (Multi-ISP) All regions support BGP (Multi-ISP).
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Japan (Tokyo), Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok).
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The billing method of the Internet Shared Bandwidth instance. Valid values: **PayByTraffic**: pay-by-data-transfer
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The name of the Internet Shared Bandwidth instance.
        /// 
        /// The name must be 2 to 128 characters in length and start with a letter, and can contain letters, digits, underscores (\_), and hyphens (-).
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
        /// The percentage of the minimum bandwidth commitment. Set the parameter to **20**.
        /// 
        /// >  This parameter is supported only on the Alibaba Cloud China site.
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// The region ID of the Internet Shared Bandwidth instance.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// You can specify up to 10 editions of Anti-DDoS.
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// The zone of the Internet Shared Bandwidth instance. This parameter must be specified when you create an Internet Shared Bandwidth instance for a cloud box.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
