// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionNumLineChartResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionNumLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionNumLineChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>The result list for the current category.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>旁路事件</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The xaxis node details.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>The data structure.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
