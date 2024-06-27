// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeHighRiskPieChartResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeHighRiskPieChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeHighRiskPieChartResponseBodyResultObject : TeaModel {
            [NameInMap("highRiskIPCity")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCity HighRiskIPCity { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCity : TeaModel {
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCityGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCityGrid : TeaModel {
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeries : TeaModel {
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeriesData : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            [NameInMap("highRiskIPProvince")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvince HighRiskIPProvince { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvince : TeaModel {
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceGrid : TeaModel {
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeries : TeaModel {
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeriesData : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            [NameInMap("highRiskMobileCity")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCity HighRiskMobileCity { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCity : TeaModel {
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCityGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCityGrid : TeaModel {
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeries : TeaModel {
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeriesData : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            [NameInMap("highRiskMobileProvince")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvince HighRiskMobileProvince { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvince : TeaModel {
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceGrid : TeaModel {
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeries : TeaModel {
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeriesData : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
