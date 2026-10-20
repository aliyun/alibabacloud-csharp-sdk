// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetOptimizeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The scheduling checkpoint, which stores states such as the general scheduling watermark.</para>
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public Dictionary<string, object> Checkpoint { get; set; }

        /// <summary>
        /// <para>The type-specific configuration. Optional prompts for ExperienceMining or SkillOptimize support only inline Markdown. The body is saved to inputs.prompt.content, which must be a non-empty UTF-8 string of up to 16 KiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ioVersion&quot;:2,&quot;inputs&quot;:{&quot;experienceLibrary&quot;:{&quot;type&quot;:&quot;dataset&quot;,&quot;dataset&quot;:&quot;experiences&quot;},&quot;trajectory&quot;:{&quot;type&quot;:&quot;sls&quot;,&quot;project&quot;:&quot;my-project&quot;,&quot;logstore&quot;:&quot;agent-trajectory&quot;,&quot;format&quot;:&quot;atif&quot;},&quot;prompt&quot;:{&quot;type&quot;:&quot;inline&quot;,&quot;format&quot;:&quot;markdown&quot;,&quot;content&quot;:&quot;# Guidance\\nExtract evidence-backed tool contracts.&quot;}},&quot;outputs&quot;:{&quot;changePlan&quot;:{&quot;type&quot;:&quot;dataset&quot;,&quot;dataset&quot;:&quot;experience-plans&quot;}},&quot;operators&quot;:[&quot;tool_contract&quot;],&quot;application&quot;:{&quot;mode&quot;:&quot;manual&quot;}}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The next scheduling trigger time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-13T16:00:00Z</para>
        /// </summary>
        [NameInMap("nextTriggerTime")]
        [Validation(Required=false)]
        public string NextTriggerTime { get; set; }

        /// <summary>
        /// <para>The optimization task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efficiency-analysis</para>
        /// </summary>
        [NameInMap("optimizeTaskName")]
        [Validation(Required=false)]
        public string OptimizeTaskName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values: Enabled, Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The optimization task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EfficiencyAnalysis</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
