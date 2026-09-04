// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Mobile node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The list of Mobile node IDs. A maximum of 100 nodes are supported per request.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum number of execution steps for the task. This prevents infinite loops. Valid values: 30 to 1000. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxSteps")]
        [Validation(Required=false)]
        public int? MaxSteps { get; set; }

        /// <summary>
        /// <para>The runtime configuration that carries the runtime parameters (skills) for this task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Skills&quot;:[&quot;sk-abc&quot;,&quot;sk-def&quot;]}</para>
        /// </summary>
        [NameInMap("RunConfig")]
        [Validation(Required=false)]
        public RunAgentTaskRequestRunConfig RunConfig { get; set; }
        public class RunAgentTaskRequestRunConfig : TeaModel {
            /// <summary>
            /// <para>The list of skill IDs. A maximum of 10 skill IDs are supported. Only the first skill is passed through during command delivery. All skills are stored in task_skill_relation for reverse lookup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sk-abc&quot;,&quot;sk-def&quot;]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<string> Skills { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to write the task artifacts to the user\&quot;s OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SaveArtifacts")]
        [Validation(Required=false)]
        public bool? SaveArtifacts { get; set; }

        /// <summary>
        /// <para>The scheduling plan ID. When specified, the execution record is associated with the corresponding scheduled node, which facilitates aggregate query by scheduling dimension through aggregation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sch-260625-pbj2****</para>
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>An array of target objects. Each element contains an InstanceId and a SessionId.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<RunAgentTaskRequestTargets> Targets { get; set; }
        public class RunAgentTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>The Mobile node ID, such as acp-xxx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-5hh4a31emkt6u****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The session ID. Tasks with the same session ID share context, such as ses-260702-21b****.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ses-260702-21bh****。</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The task configuration ID. This parameter is used to trigger a task with the specified configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tsk-260625-49be****</para>
        /// </summary>
        [NameInMap("TaskConfigId")]
        [Validation(Required=false)]
        public string TaskConfigId { get; set; }

        /// <summary>
        /// <para>The task timeout period, in seconds. Valid values: 300 to 3600. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The user instruction in natural language. The Agent performs operations based on this instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Go to App Store and download DingTalk</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
