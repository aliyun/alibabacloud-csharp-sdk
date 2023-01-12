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
        /// You can call the [ListAvailableBusiRegions](~~261190~~) operation to query the acceleration regions available for a specified GA instance.
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The line type of the elastic IP address (EIP) in the acceleration region. Default value: BGP. Valid values:
        /// 
        /// *   **BGP**: BGP (Multi-ISP) lines
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines If the acceleration region is China (Hong Kong) and a basic bandwidth plan whose bandwidth type is Premium is associated with the GA instance, the default value of IspType is BGP_PRO.
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also specify one of the following values:
        /// 
        /// *   **ChinaTelecom**: China Telecom (single ISP)
        /// *   **ChinaUnicom**: China Unicom (single ISP)
        /// *   **ChinaMobile**: China Mobile (single ISP)
        /// *   **ChinaTelecom_L2**: China Telecom \_L2 (single ISP)
        /// *   **ChinaUnicom_L2**: China Unicom \_L2 (single ISP)
        /// *   **ChinaMobile_L2**: China Mobile \_L2 (single ISP)
        /// 
        /// >  The supported single-ISP type varies with the acceleration region.
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

        /// <summary>
        /// The ID of the region where the basic GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
