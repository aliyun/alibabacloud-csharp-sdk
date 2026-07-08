// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class WritingOutline : TeaModel {
        /// <summary>
        /// <para>List of articles referenced in the outline</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<OutlineWritingArticle> Articles { get; set; }

        /// <summary>
        /// <para>List of sub-outlines</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<WritingOutline> Children { get; set; }

        /// <summary>
        /// <para>Outline</para>
        /// 
        /// <b>Example:</b>
        /// <para>大纲名称</para>
        /// </summary>
        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <para>Unique outline identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public string OutlineId { get; set; }

        /// <summary>
        /// <para>Outline writing search keyword list</para>
        /// </summary>
        [NameInMap("SearchKeyWordList")]
        [Validation(Required=false)]
        public List<string> SearchKeyWordList { get; set; }

        /// <summary>
        /// <para>Description of word count requirements, such as 1K words, 2K words, or no less than 500 words.</para>
        /// 
        /// <b>Example:</b>
        /// <para>写作字数要求的描述</para>
        /// </summary>
        [NameInMap("WordCount")]
        [Validation(Required=false)]
        public string WordCount { get; set; }

        /// <summary>
        /// <para>Outline writing requirements, writing tips</para>
        /// 
        /// <b>Example:</b>
        /// <para>大纲写作要求、写作提示</para>
        /// </summary>
        [NameInMap("WritingTips")]
        [Validation(Required=false)]
        public string WritingTips { get; set; }

    }

}
