// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionPieChartResponseBody : TeaModel {
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
        public DescribeScoreSectionPieChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionPieChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The chart field. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("animation")]
            [Validation(Required=false)]
            public bool? Animation { get; set; }

            /// <summary>
            /// <para>The grid.</para>
            /// </summary>
            [NameInMap("grid")]
            [Validation(Required=false)]
            public DescribeScoreSectionPieChartResponseBodyResultObjectGrid Grid { get; set; }
            public class DescribeScoreSectionPieChartResponseBodyResultObjectGrid : TeaModel {
                /// <summary>
                /// <para>The chart field. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

            }

            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionPieChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionPieChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>The chart data list.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeScoreSectionPieChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeScoreSectionPieChartResponseBodyResultObjectSeriesData : TeaModel {
                    /// <summary>
                    /// <para>The category item name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>名称</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The result value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分值区间占比</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The chart field. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("roseType")]
                [Validation(Required=false)]
                public bool? RoseType { get; set; }

            }

        }

    }

}
