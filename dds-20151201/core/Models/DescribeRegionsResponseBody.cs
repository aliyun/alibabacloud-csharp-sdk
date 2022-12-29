// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// Details about the regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("DdsRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsDdsRegion> DdsRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsDdsRegion : TeaModel {
                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the region.
                /// 
                /// The return value of the LocalName parameter is in the language that is specified by the **AcceptLanguage** parameter.
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// Details about the zones.
                /// </summary>
                [NameInMap("Zones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsDdsRegionZones Zones { get; set; }
                public class DescribeRegionsResponseBodyRegionsDdsRegionZones : TeaModel {
                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public List<DescribeRegionsResponseBodyRegionsDdsRegionZonesZone> Zone { get; set; }
                    public class DescribeRegionsResponseBodyRegionsDdsRegionZonesZone : TeaModel {
                        /// <summary>
                        /// Indicates whether a virtual private cloud (VPC) is supported. Valid values:
                        /// 
                        /// *   **true**: VPC is supported.
                        /// *   **false**: VPC is not supported.
                        /// </summary>
                        [NameInMap("VpcEnabled")]
                        [Validation(Required=false)]
                        public bool? VpcEnabled { get; set; }

                        /// <summary>
                        /// The ID of the zone.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                        /// <summary>
                        /// The name of the zone.
                        /// 
                        /// The return value of the LocalName parameter is in the language that is specified by the **AcceptLanguage** parameter.
                        /// </summary>
                        [NameInMap("ZoneName")]
                        [Validation(Required=false)]
                        public string ZoneName { get; set; }

                    }

                }

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
