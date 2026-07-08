// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotViewPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotViewPointsResponseBodyData> Data { get; set; }
        public class ListHotViewPointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current viewpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前观点</para>
            /// </summary>
            [NameInMap("Attitude")]
            [Validation(Required=false)]
            public string Attitude { get; set; }

            /// <summary>
            /// <para>Attitude Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>观点类型</para>
            /// </summary>
            [NameInMap("AttitudeType")]
            [Validation(Required=false)]
            public string AttitudeType { get; set; }

            /// <summary>
            /// <para>List of related news articles</para>
            /// </summary>
            [NameInMap("News")]
            [Validation(Required=false)]
            public List<ListHotViewPointsResponseBodyDataNews> News { get; set; }
            public class ListHotViewPointsResponseBodyDataNews : TeaModel {
                /// <summary>
                /// <para>Author</para>
                /// 
                /// <b>Example:</b>
                /// <para>作者</para>
                /// </summary>
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <para>Content</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>External UUID of the article</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Unique ID of the article</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                /// <summary>
                /// <para>URLs of article images</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com/aaa.png">https://www.example.com/aaa.png</a></para>
                /// </summary>
                [NameInMap("ImageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                /// <summary>
                /// <para>Published At. Format: YYYY-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-22 10:29:00</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <para>Source</para>
                /// 
                /// <b>Example:</b>
                /// <para>新浪</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>summary</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>tags</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;标签1&quot;,&quot;标签2&quot;]</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>title</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>topic</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章主题</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>Article URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Current viewpoint ratio</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前观点占比</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            /// <summary>
            /// <para>List of topic viewpoints</para>
            /// </summary>
            [NameInMap("ViewPoints")]
            [Validation(Required=false)]
            public List<ListHotViewPointsResponseBodyDataViewPoints> ViewPoints { get; set; }
            public class ListHotViewPointsResponseBodyDataViewPoints : TeaModel {
                /// <summary>
                /// <para>Outline</para>
                /// </summary>
                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<ListHotViewPointsResponseBodyDataViewPointsOutlines> Outlines { get; set; }
                public class ListHotViewPointsResponseBodyDataViewPointsOutlines : TeaModel {
                    /// <summary>
                    /// <para>Outline</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大纲</para>
                    /// </summary>
                    [NameInMap("Outline")]
                    [Validation(Required=false)]
                    public string Outline { get; set; }

                    /// <summary>
                    /// <para>Outline summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大纲摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                }

                /// <summary>
                /// <para>Generated point</para>
                /// 
                /// <b>Example:</b>
                /// <para>视角</para>
                /// </summary>
                [NameInMap("Point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <para>Summary</para>
                /// 
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Maximum number of return results</para>
        /// 
        /// <b>Example:</b>
        /// <para>67</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Fault description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Token for the next page</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
