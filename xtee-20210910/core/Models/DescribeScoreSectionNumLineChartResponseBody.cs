// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionNumLineChartResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionNumLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionNumLineChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Data list</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>List of current category results.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                /// <summary>
                /// <para>Category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>旁路事件</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Details of xaxis node.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeScoreSectionNumLineChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>Data structure.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
