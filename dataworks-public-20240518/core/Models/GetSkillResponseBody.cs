// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned Skill object.</para>
        /// </summary>
        [NameInMap("Skill")]
        [Validation(Required=false)]
        public GetSkillResponseBodySkill Skill { get; set; }
        public class GetSkillResponseBodySkill : TeaModel {
            /// <summary>
            /// <para><b>The content of the SKILL.md file.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>把大象装冰箱需要3步，把冰箱门打开，把大象放进去，把冰箱门关上。</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>A temporary download link for <c>bundle.zip</c>, which does not require authentication and will expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/xxx.zip?Expires=...&Signature=">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/xxx.zip?Expires=...&amp;Signature=</a>...</para>
            /// </summary>
            [NameInMap("BundleUrl")]
            [Validation(Required=false)]
            public string BundleUrl { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the Skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para><b>The Skill description.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>数据分析技能</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time the Skill was created, provided as a UNIX timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time the Skill was last modified, provided as a UNIX timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the Skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <para><b>The name of the Skill.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>my-skill</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para><b>The visibility level.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            /// <summary>
            /// <para><b>The visibility scope.</b></para>
            /// </summary>
            [NameInMap("VisibilityScope")]
            [Validation(Required=false)]
            public GetSkillResponseBodySkillVisibilityScope VisibilityScope { get; set; }
            public class GetSkillResponseBodySkillVisibilityScope : TeaModel {
                /// <summary>
                /// <para><b>A list of project IDs that can access the Skill.</b></para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<string> ProjectIds { get; set; }

                /// <summary>
                /// <para>A list of user IDs that can access the Skill.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

        }

    }

}
