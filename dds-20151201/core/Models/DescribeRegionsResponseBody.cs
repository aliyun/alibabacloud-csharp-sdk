// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The regions.
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
                /// The public endpoint of the region.
                /// 
                /// For example, if the value of the RegionId parameter in the response is cn-hangzhou, the following value is returned for the EndPoint parameter:
                /// 
                /// *   mongodb.aliyuncs.com
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the region.
                /// 
                /// The value of the LocalName parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the RegionId parameter in the response is **cn-hangzhou**, the following values are returned for the LocalName parameter:
                /// 
                /// *   If the value of the **AcceptLanguage** parameter is **zh**, the value **1（）** is returned for the LocalName parameter.
                /// *   If the value of the **AcceptLanguage** parameter is **en**, the value **China (Hangzhou)** is returned for the LocalName parameter.
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// The zones.
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
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                        /// <summary>
                        /// The name of the zone.
                        /// 
                        /// The value of the ZoneName parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the ZoneId parameter in the response is **cn-hangzhou-h**, the following values are returned for the ZoneName parameter:
                        /// 
                        /// *   If the value of the **AcceptLanguage** parameter is **zh**, the value **H** is returned for the ZoneName parameter.
                        /// *   If the value of the **AcceptLanguage** parameter is **en**, the value **Hangzhou Zone H** is returned for the ZoneName parameter.
                        /// </summary>
                        [NameInMap("ZoneName")]
                        [Validation(Required=false)]
                        public string ZoneName { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
