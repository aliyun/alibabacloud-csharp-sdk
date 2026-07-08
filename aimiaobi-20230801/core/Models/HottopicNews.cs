// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class HottopicNews : TeaModel {
        /// <summary>
        /// <para>List of news comments</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public List<HottopicNewsComments> Comments { get; set; }
        public class HottopicNewsComments : TeaModel {
            /// <summary>
            /// <para>News comment content</para>
            /// 
            /// <b>Example:</b>
            /// <para>新闻评论内容</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>News content</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻内容xxx</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>News title</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻标题xxx</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>News URL link</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx.html">http://www.example.com/xxx.html</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
