// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionRatioLineChartResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeScoreSectionRatioLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeScoreSectionRatioLineChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Data list</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeScoreSectionRatioLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeScoreSectionRatioLineChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>Chart data list</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                /// <summary>
                /// <para>Statistical dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>旁路事件</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Details of the xaxis node.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeScoreSectionRatioLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeScoreSectionRatioLineChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>Chart data list</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
