// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the updated agent.</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public UpdateAgentResponseBodyAgent Agent { get; set; }
        public class UpdateAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>The version of the updated agent definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public int? AgentVersion { get; set; }

            /// <summary>
            /// <para>The bound expert suites.</para>
            /// </summary>
            [NameInMap("ExpertSuites")]
            [Validation(Required=false)]
            public List<UpdateAgentResponseBodyAgentExpertSuites> ExpertSuites { get; set; }
            public class UpdateAgentResponseBodyAgentExpertSuites : TeaModel {
                /// <summary>
                /// <para>The suite description of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection of data analytics expert capabilities</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data analytics expert suite</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The suite name of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>analysis-suite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The semantic version of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.0</para>
                /// </summary>
                [NameInMap("SemanticVersion")]
                [Validation(Required=false)]
                public string SemanticVersion { get; set; }

                /// <summary>
                /// <para>The source of the expert suite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The ID of the expert suite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>suite_example</para>
                /// </summary>
                [NameInMap("SuiteId")]
                [Validation(Required=false)]
                public string SuiteId { get; set; }

                /// <summary>
                /// <para>The bound published version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>The version selection expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^1.2.3</para>
                /// </summary>
                [NameInMap("VersionSelector")]
                [Validation(Required=false)]
                public string VersionSelector { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the agent. It is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The last modified time of the agent. It is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public long? GmtModifiedTime { get; set; }

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
            /// <para>The list of bound skill references after the update.</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<UpdateAgentResponseBodyAgentSkills> Skills { get; set; }
            public class UpdateAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <para>The name of the bound custom skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-business-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the official skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks-semantic</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>The source of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The published version number of the bound custom skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>The version selection expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^1.2.3</para>
                /// </summary>
                [NameInMap("VersionSelector")]
                [Validation(Required=false)]
                public string VersionSelector { get; set; }

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
