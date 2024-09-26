// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
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
        /// <para>[{\&quot;timestamp\&quot;:1722909960000,\&quot;instanceId\&quot;:\&quot;rc-dh2jf9n6j4s14926****\&quot;,\&quot;userId\&quot;:\&quot;1695619988087373\&quot;,\&quot;Minimum\&quot;:0.097,\&quot;Maximum\&quot;:0.097,\&quot;Average\&quot;:0.097},{\&quot;timestamp\&quot;:1722910020000,\&quot;instanceId\&quot;:\&quot;rc-dh2jf9n6j4s14926****\&quot;,\&quot;userId\&quot;:\&quot;1695619988087373\&quot;,\&quot;Minimum\&quot;:0.093,\&quot;Maximum\&quot;:0.093,\&quot;Average\&quot;:0.093}]</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. If the request fails, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6178f1825f9fb76ce0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data.</para>
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
        /// <para>EA2D4F34-01A7-46EB-A339-D80882135206</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
