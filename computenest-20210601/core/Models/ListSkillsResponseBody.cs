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
        /// <para>The list of skills.</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<ListSkillsResponseBodySkills> Skills { get; set; }
        public class ListSkillsResponseBodySkills : TeaModel {
            /// <summary>
            /// <para>The time when the skill was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-10T02:22:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The download URL of the skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://testts-1.oss-cn-beijing.aliyuncs.com/app/yyb_9.1.1.zip">https://testts-1.oss-cn-beijing.aliyuncs.com/app/yyb_9.1.1.zip</a></para>
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
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SkillDescription")]
            [Validation(Required=false)]
            public string SkillDescription { get; set; }

            [NameInMap("SkillDisplayName")]
            [Validation(Required=false)]
            public string SkillDisplayName { get; set; }

            /// <summary>
            /// <para>Skill ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-111111</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The set of skill labels.</para>
            /// </summary>
            [NameInMap("SkillLabels")]
            [Validation(Required=false)]
            public List<string> SkillLabels { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reimbursement-print</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The ID of the SkillSpace to which the skill belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-11111</para>
            /// </summary>
            [NameInMap("SkillSpaceId")]
            [Validation(Required=false)]
            public string SkillSpaceId { get; set; }

            /// <summary>
            /// <para>The time when the skill was last updated.</para>
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
