// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ResumePipelineResponseBody : TeaModel {
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
        /// <para>The committed watermark, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("committedWatermark")]
        [Validation(Required=false)]
        public long? CommittedWatermark { get; set; }

        /// <summary>
        /// <para>The next scheduling trigger time, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735664400</para>
        /// </summary>
        [NameInMap("nextTriggerTime")]
        [Validation(Required=false)]
        public long? NextTriggerTime { get; set; }

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
        /// <para>The scheduling status. The value is fixed to Active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

    }

}
