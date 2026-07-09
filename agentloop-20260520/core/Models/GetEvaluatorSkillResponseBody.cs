// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluatorSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skillName&quot;:&quot;trace_context_loader&quot;,&quot;enable&quot;:true,&quot;currentVersion&quot;:&quot;1782816000000&quot;}</para>
        /// </summary>
        [NameInMap("skill")]
        [Validation(Required=false)]
        public GetEvaluatorSkillResponseBodySkill Skill { get; set; }
        public class GetEvaluatorSkillResponseBodySkill : TeaModel {
            /// <summary>
            /// <para>The time when the skill was created. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000000</para>
            /// </summary>
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>读取链路上下文辅助评估</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trace 上下文读取</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The list of skill files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;# Trace Context Loader&quot;,&quot;remark&quot;:&quot;主技能说明&quot;}]</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<GetEvaluatorSkillResponseBodySkillFiles> Files { get; set; }
            public class GetEvaluatorSkillResponseBodySkillFiles : TeaModel {
                /// <summary>
                /// <para>The file content.</para>
                /// 
                /// <b>Example:</b>
                /// <h1>Trace Context Loader</h1>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SKILL.md</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The file remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>主技能说明</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// <para>The latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000000</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace_context_loader</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The time when the skill was last updated. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816600</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            /// <summary>
            /// <para>The list of skill versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;version&quot;:&quot;1782816000000&quot;,&quot;versionDescription&quot;:&quot;首次发布版本&quot;}]</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<GetEvaluatorSkillResponseBodySkillVersions> Versions { get; set; }
            public class GetEvaluatorSkillResponseBodySkillVersions : TeaModel {
                /// <summary>
                /// <para>The time when the version was created. This value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782816000</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782816000000</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>首次发布版本</para>
                /// </summary>
                [NameInMap("versionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

        }

    }

}
