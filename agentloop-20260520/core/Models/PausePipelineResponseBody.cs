// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class PausePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace where the pipeline is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpaceName")]
        [Validation(Required=false)]
        public string AgentSpaceName { get; set; }

        /// <summary>
        /// <para>The time when the pipeline was paused, in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("pauseTime")]
        [Validation(Required=false)]
        public string PauseTime { get; set; }

        /// <summary>
        /// <para>The reason for pausing the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual maintenance</para>
        /// </summary>
        [NameInMap("pausedReason")]
        [Validation(Required=false)]
        public string PausedReason { get; set; }

        /// <summary>
        /// <para>The name of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scheduling status. The value is fixed as Paused.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Paused</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

    }

}
