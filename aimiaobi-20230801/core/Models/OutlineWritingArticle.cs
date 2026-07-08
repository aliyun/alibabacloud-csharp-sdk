// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class OutlineWritingArticle : TeaModel {
        /// <summary>
        /// <para>Content</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The leaf outline this material belongs to</para>
        /// 
        /// <b>Example:</b>
        /// <para>大纲名称</para>
        /// </summary>
        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <para>The primary outline this material belongs to</para>
        /// 
        /// <b>Example:</b>
        /// <para>一级大纲名称</para>
        /// </summary>
        [NameInMap("PrimaryOutline")]
        [Validation(Required=false)]
        public string PrimaryOutline { get; set; }

        /// <summary>
        /// <para>Publish time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-11 06:14:07</para>
        /// </summary>
        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        /// <summary>
        /// <para>Retrieval source encoding</para>
        /// 
        /// <b>Example:</b>
        /// <para>检索源编码</para>
        /// </summary>
        [NameInMap("SearchSource")]
        [Validation(Required=false)]
        public string SearchSource { get; set; }

        /// <summary>
        /// <para>Retrieval name</para>
        /// 
        /// <b>Example:</b>
        /// <para>检索源名称</para>
        /// </summary>
        [NameInMap("SearchSourceName")]
        [Validation(Required=false)]
        public string SearchSourceName { get; set; }

        /// <summary>
        /// <para>News title</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>News URL</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxxx.html">http://www.example.com/xxxx.html</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
