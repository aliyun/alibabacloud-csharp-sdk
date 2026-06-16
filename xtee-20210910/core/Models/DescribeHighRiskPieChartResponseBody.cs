// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeHighRiskPieChartResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The input parameter data is not valid. order_storage_company_num component not found</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeHighRiskPieChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeHighRiskPieChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The city to which the high-risk IP address belongs.</para>
            /// </summary>
            [NameInMap("highRiskIPCity")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCity HighRiskIPCity { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCity : TeaModel {
                /// <summary>
                /// <para>The chart identifier. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                /// <summary>
                /// <para>The grid to which the chart belongs.</para>
                /// </summary>
                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCityGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCityGrid : TeaModel {
                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                /// <summary>
                /// <para>The chart data.</para>
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeries : TeaModel {
                    /// <summary>
                    /// <para>The response data object.</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPCitySeriesData : TeaModel {
                        /// <summary>
                        /// <para>The field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>杭州市</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The data value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州市</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            /// <summary>
            /// <para>The province to which the high-risk IP address belongs.</para>
            /// </summary>
            [NameInMap("highRiskIPProvince")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvince HighRiskIPProvince { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvince : TeaModel {
                /// <summary>
                /// <para>The chart identifier. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                /// <summary>
                /// <para>The grid to which the chart belongs.</para>
                /// </summary>
                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceGrid : TeaModel {
                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                /// <summary>
                /// <para>The chart data.</para>
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeries : TeaModel {
                    /// <summary>
                    /// <para>The response data object.</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskIPProvinceSeriesData : TeaModel {
                        /// <summary>
                        /// <para>The variable name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>浙江省</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The data value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>浙江省</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            /// <summary>
            /// <para>The city to which the high-risk phone number belongs.</para>
            /// </summary>
            [NameInMap("highRiskMobileCity")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCity HighRiskMobileCity { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCity : TeaModel {
                /// <summary>
                /// <para>The chart identifier. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                /// <summary>
                /// <para>The grid to which the chart belongs.</para>
                /// </summary>
                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCityGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCityGrid : TeaModel {
                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                /// <summary>
                /// <para>The chart data.</para>
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeries : TeaModel {
                    /// <summary>
                    /// <para>The response data object.</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileCitySeriesData : TeaModel {
                        /// <summary>
                        /// <para>The field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>杭州市</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The data value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州市</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

            /// <summary>
            /// <para>The province to which the high-risk phone number belongs.</para>
            /// </summary>
            [NameInMap("highRiskMobileProvince")]
            [Validation(Required=false)]
            public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvince HighRiskMobileProvince { get; set; }
            public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvince : TeaModel {
                /// <summary>
                /// <para>The identifier. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("animation")]
                [Validation(Required=false)]
                public bool? Animation { get; set; }

                /// <summary>
                /// <para>The grid to which the chart belongs.</para>
                /// </summary>
                [NameInMap("grid")]
                [Validation(Required=false)]
                public DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceGrid Grid { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceGrid : TeaModel {
                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                }

                /// <summary>
                /// <para>The chart data.</para>
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeries> Series { get; set; }
                public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeries : TeaModel {
                    /// <summary>
                    /// <para>The high-risk location data.</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public List<DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeriesData> Data { get; set; }
                    public class DescribeHighRiskPieChartResponseBodyResultObjectHighRiskMobileProvinceSeriesData : TeaModel {
                        /// <summary>
                        /// <para>The field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>浙江省</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The data value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The display title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>分值区间占比</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The chart identifier. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("roseType")]
                    [Validation(Required=false)]
                    public string RoseType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
