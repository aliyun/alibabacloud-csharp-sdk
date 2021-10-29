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
                                public string SpecId { get; set; }
                                public string SpecName { get; set; }
                            }
                        };

                    }

                }
                public string RegionId { get; set; }
                public string RegionName { get; set; }
                public string ZoneId { get; set; }
                public string ZoneName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
