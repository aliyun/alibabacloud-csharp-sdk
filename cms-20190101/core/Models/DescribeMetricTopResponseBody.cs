// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricTopResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The monitoring data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;order\&quot;:1,\&quot;timestamp\&quot;:1620287520000,\&quot;userId\&quot;:\&quot;120886317861****\&quot;,\&quot;instanceId\&quot;:\&quot;i-j6ccf7d5fn335qpo****\&quot;,\&quot;Average\&quot;:99.92,\&quot;Minimum\&quot;:99.5,\&quot;Maximum\&quot;:100.0,\&quot;_count\&quot;:1.0},{\&quot;order\&quot;:2,\&quot;timestamp\&quot;:1620287520000,\&quot;userId\&quot;:\&quot;120886317861****\&quot;,\&quot;instanceId\&quot;:\&quot;i-0xii2bvf42iqvxbp****\&quot;,\&quot;Average\&quot;:99.91,\&quot;Minimum\&quot;:99.0,\&quot;Maximum\&quot;:100.0,\&quot;_count\&quot;:1.0}]</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data. Unit: seconds. Valid values: 15, 60, 900, and 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3121AE7D-4AFF-4C25-8F1D-C8226EBB1F42</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
