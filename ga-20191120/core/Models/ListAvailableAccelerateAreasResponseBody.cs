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
            /// The acceleration area name.
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
                /// Indicates whether the region is in the Chinese mainland. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("ChinaMainland")]
                [Validation(Required=false)]
                public bool? ChinaMainland { get; set; }

                /// <summary>
                /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
                /// 
                /// *   **BGP**: BGP (Multi-ISP) lines.
                /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines.
                /// </summary>
                [NameInMap("IspTypeList")]
                [Validation(Required=false)]
                public List<string> IspTypeList { get; set; }

                /// <summary>
                /// The acceleration region name.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// Indicates whether multiple zones are supported. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("MultiAz")]
                [Validation(Required=false)]
                public bool? MultiAz { get; set; }

                /// <summary>
                /// The ID of the acceleration region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Indicates whether IPv6 is supported. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
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
