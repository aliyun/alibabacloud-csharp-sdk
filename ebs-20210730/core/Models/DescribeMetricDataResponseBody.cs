// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The disk monitoring data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeMetricDataResponseBodyDataList> DataList { get; set; }
        public class DescribeMetricDataResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The datapoints that consist of consecutive timestamps in seconds and metric values that were recorded at these time points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;1699258861&quot;: 1,
            ///         &quot;1699259461&quot;: 0,
            ///         &quot;1699260061&quot;: 0,
            ///         &quot;1699260661&quot;: 0,
            ///         &quot;1699261261&quot;: 0,
            ///         &quot;1699261861&quot;: 0,
            ///         &quot;1699262461&quot;: 0,
            ///         &quot;1699263061&quot;: 0,
            ///         &quot;1699263661&quot;: 0,
            ///         &quot;1699264261&quot;: 0,
            ///         &quot;1699264861&quot;: 0
            /// }</para>
            /// </summary>
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public object Datapoints { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DiskId&quot;: &quot;d-1234&quot;}</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public object Labels { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11B55F58-D3A4-4A9B-9596-342420D0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data entries queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public List<string> Warnings { get; set; }

    }

}
