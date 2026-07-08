// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateTraceability : TeaModel {
        /// <summary>
        /// <para>The list of traceability news.</para>
        /// </summary>
        [NameInMap("News")]
        [Validation(Required=false)]
        public List<GenerateTraceabilityNews> News { get; set; }
        public class GenerateTraceabilityNews : TeaModel {
            /// <summary>
            /// <para>The index \<c>n\\</c> that corresponds to the \<c>[[n]]\\</c> marker in the original article. The index starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The publish time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-22 10:29:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The unique identity of the retrieval source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检索源唯一标识</para>
            /// </summary>
            [NameInMap("SearchSource")]
            [Validation(Required=false)]
            public string SearchSource { get; set; }

            /// <summary>
            /// <para>The name of the retrieval source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检索源编码</para>
            /// </summary>
            [NameInMap("SearchSourceName")]
            [Validation(Required=false)]
            public string SearchSourceName { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新闻标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com/xxx.html">http://www.example.com/xxx.html</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
