// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotNewsWithTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotNewsWithTypeResponseBodyData> Data { get; set; }
        public class ListHotNewsWithTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The news list.</para>
            /// </summary>
            [NameInMap("News")]
            [Validation(Required=false)]
            public List<ListHotNewsWithTypeResponseBodyDataNews> News { get; set; }
            public class ListHotNewsWithTypeResponseBodyDataNews : TeaModel {
                /// <summary>
                /// <para>The author.</para>
                /// 
                /// <b>Example:</b>
                /// <para>作者名称</para>
                /// </summary>
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <para>The content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新闻内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The unique identifier of the internal document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                /// <summary>
                /// <para>The image URLs.</para>
                /// </summary>
                [NameInMap("ImageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                /// <summary>
                /// <para>The publish time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-11 06:14:07</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <para>The search source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新浪热榜</para>
                /// </summary>
                [NameInMap("SearchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                /// <summary>
                /// <para>The search source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新浪热榜</para>
                /// </summary>
                [NameInMap("SearchSourceName")]
                [Validation(Required=false)]
                public string SearchSourceName { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新浪新闻综合</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The article summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>社会</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

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
                /// <para>The system update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-14 14:30:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The article URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/a.html">http://www.example.com/a.html</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The news category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>society: social current affairs.</description></item>
            /// <item><description>person: people news.</description></item>
            /// <item><description>government: government affairs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>society</para>
            /// </summary>
            [NameInMap("NewsType")]
            [Validation(Required=false)]
            public string NewsType { get; set; }

            /// <summary>
            /// <para>The news category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>社会时事</para>
            /// </summary>
            [NameInMap("NewsTypeName")]
            [Validation(Required=false)]
            public string NewsTypeName { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
