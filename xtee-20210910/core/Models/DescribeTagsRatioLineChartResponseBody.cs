// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsRatioLineChartResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeTagsRatioLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsRatioLineChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Data list</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsRatioLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsRatioLineChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>Result data.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

                /// <summary>
                /// <para>Series name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rn101</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>xaxis node.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsRatioLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsRatioLineChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>X-axis data</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

    }

}
