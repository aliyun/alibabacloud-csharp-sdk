// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class OutlineSearchResult : TeaModel {
        /// <summary>
        /// <para>A list of retrieved materials.</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<OutlineWritingArticle> Articles { get; set; }

        /// <summary>
        /// <para>The retrieved outline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>晨光中的自律：清晨6:30的校园</para>
        /// </summary>
        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <para>The unique identifier of the outline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public string OutlineId { get; set; }

        /// <summary>
        /// <para>The primary outline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>大学生正能量的一天</para>
        /// </summary>
        [NameInMap("PrimaryOutline")]
        [Validation(Required=false)]
        public string PrimaryOutline { get; set; }

        /// <summary>
        /// <para>The retrieval query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高校环保义卖案例 大学生旧物循环利用率的文章</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
