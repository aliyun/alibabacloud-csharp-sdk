// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicIpSetRequest : TeaModel {
        /// <summary>
        /// The ID of the acceleration region.
        /// 
        /// You can call the [ListAvailableBusiRegions](https://help.aliyun.com/document_detail/261190.html) operation to query the most recent acceleration region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth that you want to allocate to the acceleration region. Unit: **Mbit/s**.
        /// 
        /// You must allocate at least 2 Mbit/s of bandwidth to the acceleration region.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines.
        /// 
        /// Valid values if you are allowed to use single-ISP bandwidth:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// 
        /// > 
        /// 
        /// *   If the bandwidth metering method of the GA instance is **pay-by-data-transfer**, this parameter is required.
        /// 
        /// *   If the acceleration region is China (Hong Kong) and a basic bandwidth plan whose bandwidth type is Premium is associated with the GA instance, the default value of IspType is BGP_PRO.
        /// 
        /// *   The supported single-ISP type varies based on the acceleration region.
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

        /// <summary>
        /// The region ID of the basic GA instance. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
