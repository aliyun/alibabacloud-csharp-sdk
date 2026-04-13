// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("DdsRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsDdsRegion> DdsRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsDdsRegion : TeaModel {
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("Zones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsDdsRegionZones Zones { get; set; }
                public class DescribeRegionsResponseBodyRegionsDdsRegionZones : TeaModel {
                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public List<DescribeRegionsResponseBodyRegionsDdsRegionZonesZone> Zone { get; set; }
                    public class DescribeRegionsResponseBodyRegionsDdsRegionZonesZone : TeaModel {
                        [NameInMap("VpcEnabled")]
                        [Validation(Required=false)]
                        public bool? VpcEnabled { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                        [NameInMap("ZoneName")]
                        [Validation(Required=false)]
                        public string ZoneName { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E46C22C-D3B7-4DB8-9C76-63851BE68E20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
