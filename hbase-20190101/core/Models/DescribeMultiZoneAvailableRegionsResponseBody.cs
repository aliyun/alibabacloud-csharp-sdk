// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMultiZoneAvailableRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeMultiZoneAvailableRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegion : TeaModel {
                [NameInMap("AvailableCombines")]
                [Validation(Required=false)]
                public DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombines AvailableCombines { get; set; }
                public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombines : TeaModel {
                    [NameInMap("AvailableCombine")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombine> AvailableCombine { get; set; }
                    public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombine : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-shenzhen-****-aliyun</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Zones")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombineZones Zones { get; set; }
                        public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombineZones : TeaModel {
                            [NameInMap("Zone")]
                            [Validation(Required=false)]
                            public List<string> Zone { get; set; }

                        }

                    }

                }

                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hbase.aliyuncs.com</para>
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F03BB273-45EE-4B6C-A329-A6E6A8D15856</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
