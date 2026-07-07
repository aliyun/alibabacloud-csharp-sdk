// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of skill details.</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<ListSkillsResponseBodySkills> Skills { get; set; }
        public class ListSkillsResponseBodySkills : TeaModel {
            /// <summary>
            /// <para>The API key of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>akm-98f66829***</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Li***</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>The currently effective version number. If no version is effective, an empty value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The description of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This skill is used for****</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name****</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// </summary>
            [NameInMap("EnvVars")]
            [Validation(Required=false)]
            public Dictionary<string, string> EnvVars { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-28T10:32:53Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The URL of the skill icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<em><b>-</b></em>-****</para>
            /// </summary>
            [NameInMap("SkillIconUrl")]
            [Validation(Required=false)]
            public string SkillIconUrl { get; set; }

            /// <summary>
            /// <para>The unique identifier of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-04rj8mzqj1fu****</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The name in the SKILL.md file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name****</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            [NameInMap("SkillVersions")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodySkillsSkillVersions> SkillVersions { get; set; }
            public class ListSkillsResponseBodySkillsSkillVersions : TeaModel {
                [NameInMap("ChangeLog")]
                [Validation(Required=false)]
                public string ChangeLog { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("SecurityScanFailReason")]
                [Validation(Required=false)]
                public string SecurityScanFailReason { get; set; }

                [NameInMap("SecurityScanScore")]
                [Validation(Required=false)]
                public int? SecurityScanScore { get; set; }

                [NameInMap("SecurityScanStatus")]
                [Validation(Required=false)]
                public string SecurityScanStatus { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The slug identifier of the skill. This value is user-defined and unique within the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>find-skills****</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>The source marketplace code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLAWHUB</para>
            /// </summary>
            [NameInMap("SourceMarket")]
            [Validation(Required=false)]
            public string SourceMarket { get; set; }

            /// <summary>
            /// <para>The source marketplace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClawHub</para>
            /// </summary>
            [NameInMap("SourceMarketName")]
            [Validation(Required=false)]
            public string SourceMarketName { get; set; }

            /// <summary>
            /// <para>The supply type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("SupplierType")]
            [Validation(Required=false)]
            public string SupplierType { get; set; }

        }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
