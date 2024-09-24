// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
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
        /// <para>The monitoring data. The value includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><c>timestamp</c>: the time when the alert was triggered.</description></item>
        /// <item><description><c>userId</c>: the ID of the user for which the alert was triggered.</description></item>
        /// <item><description><c>instanceId</c>: the ID of the instance for which the alert was triggered.</description></item>
        /// <item><description><c>Minimum</c>, <c>Average</c>, and <c>Maximum</c>: the aggregation methods.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;timestamp\&quot;:1618368900000,\&quot;Average\&quot;:95.8291666666667,\&quot;Minimum\&quot;:65.48,\&quot;Maximum\&quot;:100.0},{\&quot;timestamp\&quot;:1618368960000,\&quot;Average\&quot;:95.8683333333333,\&quot;Minimum\&quot;:67.84,\&quot;Maximum\&quot;:100.0}]</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data.</para>
        /// <para>Valid values: 15, 60, 900, and 3600.</para>
        /// <para>Unit: seconds.</para>
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
        /// <para>6A5F022D-AC7C-460E-94AE-B9E75083D027</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
