// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class TerminatePipelineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpaceName")]
        [Validation(Required=false)]
        public string AgentSpaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Terminated</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("terminateTime")]
        [Validation(Required=false)]
        public string TerminateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project deprecated</para>
        /// </summary>
        [NameInMap("terminatedReason")]
        [Validation(Required=false)]
        public string TerminatedReason { get; set; }

    }

}
