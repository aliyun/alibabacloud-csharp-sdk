// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentExplorer20260317.Models
{
    public class Skill : TeaModel {
        /// <summary>
        /// <para>The primary category code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("categoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <para>The primary category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>计算</para>
        /// </summary>
        [NameInMap("categoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("categoryNameEn")]
        [Validation(Required=false)]
        public string CategoryNameEn { get; set; }

        /// <summary>
        /// <para>The time when the Agent Skill was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the Agent Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS 实例管理</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("descriptionEn")]
        [Validation(Required=false)]
        public string DescriptionEn { get; set; }

        /// <summary>
        /// <para>The display name of the Agent Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS 实例管理</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("githubPath")]
        [Validation(Required=false)]
        public string GithubPath { get; set; }

        /// <summary>
        /// <para>The number of installations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("installCount")]
        [Validation(Required=false)]
        public int? InstallCount { get; set; }

        /// <summary>
        /// <para>The number of likes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("likeCount")]
        [Validation(Required=false)]
        public int? LikeCount { get; set; }

        [NameInMap("nameEn")]
        [Validation(Required=false)]
        public string NameEn { get; set; }

        /// <summary>
        /// <para>The English name of the Agent Skill, which serves as a unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deploy-to-vercel</para>
        /// </summary>
        [NameInMap("skillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The secondary category code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("subCategoryCode")]
        [Validation(Required=false)]
        public string SubCategoryCode { get; set; }

        /// <summary>
        /// <para>The secondary category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>弹性计算</para>
        /// </summary>
        [NameInMap("subCategoryName")]
        [Validation(Required=false)]
        public string SubCategoryName { get; set; }

        [NameInMap("subCategoryNameEn")]
        [Validation(Required=false)]
        public string SubCategoryNameEn { get; set; }

        /// <summary>
        /// <para>The time when the Agent Skill was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-17T00:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
