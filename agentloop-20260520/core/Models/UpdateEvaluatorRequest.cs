// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluatorRequest : TeaModel {
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
        /// <para>The configuration for the new version. This parameter is typically required when version is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;prompt&quot;:&quot;Evaluate task completion more strictly&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a new draft. Set to true to create a new draft, or false to update a specified existing draft. When this parameter is specified, the version status defaults to DRAFT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("createVersion")]
        [Validation(Required=false)]
        public bool? CreateVersion { get; set; }

        /// <summary>
        /// <para>The description of the evaluator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Determines whether the agent completes the user task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pipeline task completion</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

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
        /// <para>The complete list of business skills saved for the standard agent evaluator in this request. Pass an empty array to clear the business skills for this version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;skillName&quot;:&quot;fact-check&quot;,&quot;files&quot;:[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;---\nname: fact-check\ndescription: Verify factual basis in responses\n---\nVerify the facts in the response item by item and list the basis.&quot;}]}]</para>
        /// </summary>
        [NameInMap("skills")]
        [Validation(Required=false)]
        public List<UpdateEvaluatorRequestSkills> Skills { get; set; }
        public class UpdateEvaluatorRequestSkills : TeaModel {
            /// <summary>
            /// <para>The description of the skill purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify factual basis in responses</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fact-checking</para>
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
            /// <para>The complete list of files for the skill, which must include SKILL.md in the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;---\nname: fact-check\ndescription: Verify factual basis in responses\n---\nVerify the facts in the response item by item and list the basis.&quot;}]</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<UpdateEvaluatorRequestSkillsFiles> Files { get; set; }
            public class UpdateEvaluatorRequestSkillsFiles : TeaModel {
                /// <summary>
                /// <para>The text content of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// <h2>name: fact-check
                /// description: Verify factual basis in responses</h2>
                /// <para>Verify the facts in the response item by item and list the basis</para>
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
            /// <para>The name of the skill, which must be unique in the list of skills submitted in this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fact-check</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

        }

        /// <summary>
        /// <para>The status of the evaluator version to be written. Only DRAFT is supported when explicitly specified. To publish a draft, call UpdateEvaluatorVersionStatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The new version number. A new version is created when this parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Optimized scoring instructions</para>
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
