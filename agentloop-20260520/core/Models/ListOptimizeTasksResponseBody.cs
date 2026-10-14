// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListOptimizeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of optimization tasks.</para>
        /// </summary>
        [NameInMap("optimizeTasks")]
        [Validation(Required=false)]
        public List<ListOptimizeTasksResponseBodyOptimizeTasks> OptimizeTasks { get; set; }
        public class ListOptimizeTasksResponseBodyOptimizeTasks : TeaModel {
            /// <summary>
            /// <para>The scheduling checkpoint that stores states such as the general scheduling watermark.</para>
            /// </summary>
            [NameInMap("checkpoint")]
            [Validation(Required=false)]
            public Dictionary<string, object> Checkpoint { get; set; }

            /// <summary>
            /// <para>The type-specific configuration. For ExperienceMining and SkillOptimize, optional prompts support only inline Markdown, and the body is stored in inputs.prompt.content (non-empty UTF-8, up to 16 KiB).</para>
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
            /// <para>The name of the optimization task.</para>
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
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the optimization task. Valid values: ExperienceMining, SkillOptimize, EfficiencyAnalysis, SOPGeneration, EvalMining, PolicyMining, and AssetMining.</para>
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
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
