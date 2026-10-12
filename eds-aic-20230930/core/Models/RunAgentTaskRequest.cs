// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the Mobile node resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The list of Mobile node IDs. A single request supports up to 100 nodes.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum number of execution steps for the task to prevent infinite loops. Valid values: 50 to 1000. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxSteps")]
        [Validation(Required=false)]
        public int? MaxSteps { get; set; }

        /// <summary>
        /// <para>The runtime configuration that contains the runtime parameters such as skills for the current task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Skills&quot;:[&quot;sk-abc&quot;,&quot;sk-def&quot;]}</para>
        /// </summary>
        [NameInMap("RunConfig")]
        [Validation(Required=false)]
        public RunAgentTaskRequestRunConfig RunConfig { get; set; }
        public class RunAgentTaskRequestRunConfig : TeaModel {
            /// <summary>
            /// <para>The list of skill IDs. You can specify up to 10 skill IDs. Only the first skill ID is passed through when the command is delivered. All skill IDs are stored in the task_skill_relation table for reverse lookup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sk-abc&quot;,&quot;sk-def&quot;]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<string> Skills { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to save the task artifacts to your OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SaveArtifacts")]
        [Validation(Required=false)]
        public bool? SaveArtifacts { get; set; }

        /// <summary>
        /// <para>The ID of the scheduling plan. When specified, the execute record is associated with the corresponding scheduled node, which facilitates aggregate query by scheduling aggregation dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sch-260625-pbj2****</para>
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>The list of targets. Each element is an object that contains an InstanceId and a SessionId.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<RunAgentTaskRequestTargets> Targets { get; set; }
        public class RunAgentTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>The ID of the Mobile node, such as acp-xxx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-5hh4a31emkt6u****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The session ID. Tasks with the same session ID share the context, such as ses-260702-21b****.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ses-260702-21bh****。</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the task configuration. This parameter is used to trigger a task with the specified configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tsk-260625-49be****</para>
        /// </summary>
        [NameInMap("TaskConfigId")]
        [Validation(Required=false)]
        public string TaskConfigId { get; set; }

        /// <summary>
        /// <para>The timeout period of the task in seconds. Valid values: 300 to 3600. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The user prompt in natural language. The agent performs operations based on this prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Download DingTalk from the app store</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
