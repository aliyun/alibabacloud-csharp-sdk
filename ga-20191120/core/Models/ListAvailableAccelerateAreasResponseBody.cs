// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// The information about acceleration areas.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAvailableAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAvailableAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// The ID of the acceleration area.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The name of the acceleration area.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The information about acceleration regions.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAvailableAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAvailableAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// Whether China Mainland.
                /// </summary>
                [NameInMap("ChinaMainland")]
                [Validation(Required=false)]
                public bool? ChinaMainland { get; set; }

                /// <summary>
                /// The line types of EIPs in the acceleration region.
                /// 
                /// *   **BGP**: BGP (Multi-ISP) lines
                /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines
                /// 
                /// If you have the permissions to use single-ISP bandwidth, one of the following values may be returned:
                /// 
                /// *   **ChinaTelecom**: China Telecom (single ISP)
                /// *   **ChinaUnicom**: China Unicom (single ISP)
                /// *   **ChinaMobile**: China Mobile (single ISP)
                /// *   **ChinaTelecom_L2**: China Telecom_L2 (single ISP)
                /// *   **ChinaUnicom_L2**: China Unicom_L2 (single ISP)
                /// *   **ChinaMobile_L2**: China Mobile_L2 (single ISP)
                /// 
                /// > Different acceleration regions support different single-ISP BGP lines.
                /// </summary>
                [NameInMap("IspTypeList")]
                [Validation(Required=false)]
                public List<string> IspTypeList { get; set; }

                /// <summary>
                /// The name of the acceleration region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the acceleration region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Ipv6 supported, Valid values:
                /// 
                /// - true
                /// - false
                /// </summary>
                [NameInMap("SupportIpv6")]
                [Validation(Required=false)]
                public bool? SupportIpv6 { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
