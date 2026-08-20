// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>06BF8F22-02DC-4750-83DF-3FFC11C065EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of Skills.</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<ListSkillsResponseBodySkills> Skills { get; set; }
        public class ListSkillsResponseBodySkills : TeaModel {
            /// <summary>
            /// <para>The time when the Skill was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-10T02:22:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The download URL for the Skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/skill-creator.zip">https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/skill-creator.zip</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Locales")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodySkillsLocales> Locales { get; set; }
            public class ListSkillsResponseBodySkillsLocales : TeaModel {
                [NameInMap("EnValue")]
                [Validation(Required=false)]
                public string EnValue { get; set; }

                [NameInMap("OriginalValue")]
                [Validation(Required=false)]
                public string OriginalValue { get; set; }

                [NameInMap("ZhValue")]
                [Validation(Required=false)]
                public string ZhValue { get; set; }

            }

            /// <summary>
            /// <para>The set of connection types that the Skill depends on.</para>
            /// </summary>
            [NameInMap("RequiredConnections")]
            [Validation(Required=false)]
            public List<string> RequiredConnections { get; set; }

            /// <summary>
            /// <para>The security scan status of the source file.</para>
            /// </summary>
            [NameInMap("SecurityScanStatus")]
            [Validation(Required=false)]
            public string SecurityScanStatus { get; set; }

            /// <summary>
            /// <para>The Skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create new skills, modify and improve existing skills, and measure skill performance.</para>
            /// </summary>
            [NameInMap("SkillDescription")]
            [Validation(Required=false)]
            public string SkillDescription { get; set; }

            /// <summary>
            /// <para>The Skill display name.</para>
            /// </summary>
            [NameInMap("SkillDisplayName")]
            [Validation(Required=false)]
            public string SkillDisplayName { get; set; }

            /// <summary>
            /// <para>Skill ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-xxxxx</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The set of Skill labels.</para>
            /// </summary>
            [NameInMap("SkillLabels")]
            [Validation(Required=false)]
            public List<string> SkillLabels { get; set; }

            /// <summary>
            /// <para>The Skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-creator</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The ID of the SkillSpace to which the Skill belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-xxxxx</para>
            /// </summary>
            [NameInMap("SkillSpaceId")]
            [Validation(Required=false)]
            public string SkillSpaceId { get; set; }

            /// <summary>
            /// <para>The time when the Skill was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-03T22:58:52Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
