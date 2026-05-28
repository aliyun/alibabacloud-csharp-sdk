// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentExplorer20260317.Models
{
    public class Skill : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("categoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        [NameInMap("categoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("installCount")]
        [Validation(Required=false)]
        public int? InstallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("likeCount")]
        [Validation(Required=false)]
        public int? LikeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deploy-to-vercel</para>
        /// </summary>
        [NameInMap("skillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("subCategoryCode")]
        [Validation(Required=false)]
        public string SubCategoryCode { get; set; }

        [NameInMap("subCategoryName")]
        [Validation(Required=false)]
        public string SubCategoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-17T00:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
