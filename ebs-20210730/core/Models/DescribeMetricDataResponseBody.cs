// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>A collection of monitoring data for the disk.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeMetricDataResponseBodyDataList> DataList { get; set; }
        public class DescribeMetricDataResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>A list of monitoring data. The list contains a series of consecutive second-level timestamps and the corresponding metric values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;1699258861&quot;: 1,&quot;1699259461&quot;: 0}</para>
            /// </summary>
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public object Datapoints { get; set; }

            /// <summary>
            /// <para>The labels.</para>
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
        /// <para>The total number of data entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of warning messages.</para>
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public List<string> Warnings { get; set; }

    }

}
