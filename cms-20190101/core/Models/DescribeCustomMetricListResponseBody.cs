// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code.</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AF425E4-1DEA-54F2-910A-8117C9686140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The reported custom metrics that are found in the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;all\&quot;:0,\&quot;size\&quot;:10,\&quot;param\&quot;:{\&quot;metric\&quot;:\&quot;{\\\&quot;metricName\\\&quot;:\\\&quot;cpu_total\\\&quot;,\\\&quot;groupId\\\&quot;:7378****,\\\&quot;project\\\&quot;:\\\&quot;acs_customMetric_120886317861****\\\&quot;,\\\&quot;dimension\\\&quot;:\\\&quot;sampleName1=value1&amp;sampleName2=value2\\\&quot;,\\\&quot;status\\\&quot;:1}\&quot;,\&quot;service\&quot;:\&quot;metric-center.aliyun-inc.com\&quot;},\&quot;page\&quot;:1,\&quot;list\&quot;:[]}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
