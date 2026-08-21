// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;AliYunDun:1657494 process (1657494): Based on the provided hot spot call stack information, the hot spot is mainly concentrated on <c>__nanosleep_nocancel</c> and the related system call <c>SyS_nanosleep</c>, which indicates that the process is waiting for a specific time interval. This is usually caused by long sleep periods or high-frequency timed operations in the application, such as scheduled tasks and heartbeat detection.\n\nThe application code uses <c>nanosleep</c> to implement precise delay control when it needs to periodically perform certain checks or wait for external events. To optimize this situation, consider the following approaches:\n- Evaluate whether the frequency of scheduled tasks can be reduced.\n- Use condition variables instead of simple sleep waits to respond to faster event triggers.\n- If it is an I/O-intensive operation wait, consider optimizing the I/O path or improving I/O efficiency. Use the IO diagnostic tool on the SysOM platform to further locate specific I/O bottlenecks.&quot;</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
