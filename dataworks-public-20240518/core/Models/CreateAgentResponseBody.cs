// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the created agent.</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public CreateAgentResponseBodyAgent Agent { get; set; }
        public class CreateAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>已保存的套件引用。官方资源返回来源及目录 ID；发布后的制品版本由 PackageVersion 表示。</para>
            /// </summary>
            [NameInMap("ExpertSuites")]
            [Validation(Required=false)]
            public List<CreateAgentResponseBodyAgentExpertSuites> ExpertSuites { get; set; }
            public class CreateAgentResponseBodyAgentExpertSuites : TeaModel {
                /// <summary>
                /// <para>创建时不返回；请使用 GetAgent 显式查询已发布版本获取固定的官方套件制品版本。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0.202610211408</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dataworks-data-analysis-extension</para>
                /// </summary>
                [NameInMap("SuiteId")]
                [Validation(Required=false)]
                public string SuiteId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The last modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>已保存的 Skill 引用；官方 Skill 在 Agent 发布后返回固定的 PackageVersion。</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<CreateAgentResponseBodyAgentSkills> Skills { get; set; }
            public class CreateAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-business-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>创建时不返回；请使用 GetAgent 显式查询已发布版本获取固定的官方制品版本。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6.0.202608201110</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dataworks-semantic</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
