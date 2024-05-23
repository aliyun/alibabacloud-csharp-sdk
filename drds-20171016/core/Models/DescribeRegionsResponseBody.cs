// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("DrdsRegions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyDrdsRegions DrdsRegions { get; set; }
        public class DescribeRegionsResponseBodyDrdsRegions : TeaModel {
            [NameInMap("DrdsRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyDrdsRegionsDrdsRegion> DrdsRegion { get; set; }
            public class DescribeRegionsResponseBodyDrdsRegionsDrdsRegion : TeaModel {
                [NameInMap("InstanceSeriesList")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesList InstanceSeriesList { get; set; }
                public class DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesList : TeaModel {
                    [NameInMap("InstanceSeries")]
                    [Validation(Required=false)]
                    public List<DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeries> InstanceSeries { get; set; }
                    public class DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeries : TeaModel {
                        [NameInMap("SeriesId")]
                        [Validation(Required=false)]
                        public string SeriesId { get; set; }

                        [NameInMap("SeriesName")]
                        [Validation(Required=false)]
                        public string SeriesName { get; set; }

                        [NameInMap("SpecList")]
                        [Validation(Required=false)]
                        public DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeriesSpecList SpecList { get; set; }
                        public class DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeriesSpecList : TeaModel {
                            [NameInMap("Spec")]
                            [Validation(Required=false)]
                            public List<DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeriesSpecListSpec> Spec { get; set; }
                            public class DescribeRegionsResponseBodyDrdsRegionsDrdsRegionInstanceSeriesListInstanceSeriesSpecListSpec : TeaModel {
                                [NameInMap("SpecId")]
                                [Validation(Required=false)]
                                public string SpecId { get; set; }

                                [NameInMap("SpecName")]
                                [Validation(Required=false)]
                                public string SpecName { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
