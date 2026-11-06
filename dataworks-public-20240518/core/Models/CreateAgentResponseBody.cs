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
            /// <para>The saved suite references. Official resources return the source and directory ID. The published artifact version is represented by PackageVersion.</para>
            /// </summary>
            [NameInMap("ExpertSuites")]
            [Validation(Required=false)]
            public List<CreateAgentResponseBodyAgentExpertSuites> ExpertSuites { get; set; }
            public class CreateAgentResponseBodyAgentExpertSuites : TeaModel {
                /// <summary>
                /// <para>This field is not returned during creation. Use GetAgent to explicitly query the published version to obtain the fixed official suite artifact version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0.202610211408</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

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
                /// <para>dataworks-data-analysis-extension</para>
                /// </summary>
                [NameInMap("SuiteId")]
                [Validation(Required=false)]
                public string SuiteId { get; set; }

                /// <summary>
                /// <para>The release version number of the custom suite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>The saved version selection strategy is returned only for personal or enterprise resources and is mutually exclusive with the fixed integer Version. It does not represent the specific revision actually loaded in the session. This field is not returned for official resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^1.2.3</para>
                /// </summary>
                [NameInMap("VersionSelector")]
                [Validation(Required=false)]
                public string VersionSelector { get; set; }

            }

            /// <summary>
            /// <para>The creation time, expressed as a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The last modification time, expressed as a timestamp in milliseconds.</para>
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
            /// <para>The saved skill references. Official skills return a fixed PackageVersion after the agent is published.</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<CreateAgentResponseBodyAgentSkills> Skills { get; set; }
            public class CreateAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <para>The name of the custom skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-business-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This field is not returned during creation. Use GetAgent to explicitly query the published version to obtain the fixed official artifact version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6.0.202608201110</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

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
                /// <para>The release version number of the custom skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>The saved version selection strategy is returned only for personal or enterprise resources and is mutually exclusive with the fixed integer Version. It does not represent the specific revision actually loaded in the session. This field is not returned for official resources.</para>
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
