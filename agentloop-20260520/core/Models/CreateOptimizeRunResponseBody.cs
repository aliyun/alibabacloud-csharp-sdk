// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateOptimizeRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the created run. You can call the GetOptimizeRun operation to query the subsequent status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;optimizeRunId&quot;:&quot;opr-20261014&quot;,&quot;status&quot;:&quot;Pending&quot;}</para>
        /// </summary>
        [NameInMap("optimizeRun")]
        [Validation(Required=false)]
        public Dictionary<string, object> OptimizeRun { get; set; }

        /// <summary>
        /// <para>The run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opr-20261014</para>
        /// </summary>
        [NameInMap("optimizeRunId")]
        [Validation(Required=false)]
        public string OptimizeRunId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
