// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateDocShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231001028593</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public string DocMetadataShrink { get; set; }

        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-11T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001905617</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public string TagIdsShrink { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
