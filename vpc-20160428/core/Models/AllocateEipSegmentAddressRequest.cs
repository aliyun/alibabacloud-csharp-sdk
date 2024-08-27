// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressRequest : TeaModel {
        /// <summary>
        /// The maximum bandwidth of the contiguous EIP group. Unit: Mbit/s.
        /// 
        /// *   Valid values when **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByBandwidth**: **1** to **500**.****
        /// *   Valid values when **InstanceChargeType** is set to **PostPaid** and **InternetChargeType** is set to **PayByTraffic**: **1** to **200**.****
        /// *   Valid values when **InstanceChargeType** is set to **PrePaid**: **1** to **1000**.****
        /// 
        /// Default value: **5**. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. **ClientToken** can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subnet mask of the contiguous EIP group. Valid values:
        /// 
        /// *   **28**: applies for 16 contiguous EIPs in each call.
        /// *   **27**: applies for 32 contiguous EIPs in each call.
        /// *   **26**: applies for 64 contiguous EIPs in each call.
        /// *   **25**: applies for 128 contiguous EIPs in each call.
        /// *   **24**: applies for 256 contiguous EIPs in each call.
        /// 
        /// >  Some IP address are reserved for specific purposes. Therefore, the actual number of the contiguous EIPs may be one, three, or four less than the expected number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EipMask")]
        [Validation(Required=false)]
        public string EipMask { get; set; }

        /// <summary>
        /// The metering method of contiguous EIPs. Valid values:
        /// 
        /// *   **PayByBandwidth** (default)
        /// *   **PayByTraffic**
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) line The BGP (Multi-ISP) line is supported in all regions.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro line BGP (Multi-ISP) Pro line is supported only in the China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.
        /// 
        /// For more information about the BGP (Multi-ISP) line and BGP (Multi-ISP) Pro line, see [EIP line types](https://help.aliyun.com/document_detail/32321.html).
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also use one of the following values:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the parameter to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The network type. Set the value to **public**, which specifies the public network type.
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
        /// The ID of the region in which the contiguous EIP group resides.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
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
        /// The zone of the contiguous EIP group.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
