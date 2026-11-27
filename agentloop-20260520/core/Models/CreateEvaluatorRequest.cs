// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateEvaluatorRequest : TeaModel {
        /// <summary>
        /// <para>The list of annotation tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;__en&quot;]</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<string> Annotations { get; set; }

        /// <summary>
        /// <para>The evaluator configuration. For LLM or AGENT evaluators, the configuration typically includes prompt, variables, and outputSchema. For CODE evaluators, it typically includes codeType, faasConfig, variables, and parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;prompt&quot;:&quot;Please evaluate the task completion&quot;,&quot;variables&quot;:[{&quot;name&quot;:&quot;input&quot;}]}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The description of the evaluator. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Determines whether the agent completes the user task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trace task completion</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the evaluation metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_task_completion</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The name of the evaluator. The name cannot start with a system-reserved prefix and can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The evaluator properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;agentEvaluatorMode&quot;:&quot;raw_prompt&quot;}</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The list of business skills for the initial version of a standard agent evaluator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;skillName&quot;:&quot;fact-check&quot;,&quot;files&quot;:[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;---\nname: fact-check\ndescription: Verify the factual basis in the response\n---\nVerify the facts in the response item by item and list the evidence.&quot;}]}]</para>
        /// </summary>
        [NameInMap("skills")]
        [Validation(Required=false)]
        public List<CreateEvaluatorRequestSkills> Skills { get; set; }
        public class CreateEvaluatorRequestSkills : TeaModel {
            /// <summary>
            /// <para>The description of the skill purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify the factual basis in the response</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fact check</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the skill. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The complete list of files for the skill. The list must include SKILL.md in the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;---\nname: fact-check\ndescription: Verify the factual basis in the response\n---\nVerify the facts in the response item by item and list the evidence.&quot;}]</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<CreateEvaluatorRequestSkillsFiles> Files { get; set; }
            public class CreateEvaluatorRequestSkillsFiles : TeaModel {
                /// <summary>
                /// <para>The text content of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// <h2>name: fact-check
                /// description: Verify the factual basis in the response</h2>
                /// <para>Verify the facts in the response item by item and list the evidence</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The path of the file relative to the root directory of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SKILL.md</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the skill. The name must be unique in the list of skills submitted in this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fact-check</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

        }

        /// <summary>
        /// <para>The initial version status. Set this parameter to DRAFT to save the evaluator as a draft. If you omit this parameter, the initial version is directly published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the evaluator. <c>LLM</c> indicates an inner join model evaluation tool for large language models, <c>AGENT</c> indicates a StarOps digital employee evaluator, and <c>CODE</c> indicates a code evaluator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The initial version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The idempotency token. CloudSpec declares this query parameter, but the backend does not currently perform idempotency checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
