// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetHotTopicBroadcastResponseBody : TeaModel {
        /// <summary>
        /// <para>status code</para>
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
        public GetHotTopicBroadcastResponseBodyData Data { get; set; }
        public class GetHotTopicBroadcastResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of hot spot bulletins</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetHotTopicBroadcastResponseBodyDataData> Data { get; set; }
            public class GetHotTopicBroadcastResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>Hot topic category</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点话题分类</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Creation Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>创建时间</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Custom hotness value</para>
                /// 
                /// <b>Example:</b>
                /// <para>34.7905341705522</para>
                /// </summary>
                [NameInMap("CustomHotValue")]
                [Validation(Required=false)]
                public double? CustomHotValue { get; set; }

                /// <summary>
                /// <para>Custom text summarization of the hot spot topic</para>
                /// 
                /// <b>Example:</b>
                /// <para>自定义热点话题文本摘要</para>
                /// </summary>
                [NameInMap("CustomTextSummary")]
                [Validation(Required=false)]
                public string CustomTextSummary { get; set; }

                /// <summary>
                /// <para>Name of the hot spot topic</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点话题名称</para>
                /// </summary>
                [NameInMap("HotTopic")]
                [Validation(Required=false)]
                public string HotTopic { get; set; }

                /// <summary>
                /// <para>hot spot topic summary Version</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点话题摘要版本</para>
                /// </summary>
                [NameInMap("HotTopicVersion")]
                [Validation(Required=false)]
                public string HotTopicVersion { get; set; }

                /// <summary>
                /// <para>Hotness value</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.4120480606282884</para>
                /// </summary>
                [NameInMap("HotValue")]
                [Validation(Required=false)]
                public double? HotValue { get; set; }

                /// <summary>
                /// <para>hot spot topic ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点话题ID</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>List of hot spot topic images</para>
                /// </summary>
                [NameInMap("Images")]
                [Validation(Required=false)]
                public List<GetHotTopicBroadcastResponseBodyDataDataImages> Images { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataImages : TeaModel {
                    /// <summary>
                    /// <para>URL link</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/a.png">http://www.example.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Input Token</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("InputToken")]
                [Validation(Required=false)]
                public int? InputToken { get; set; }

                /// <summary>
                /// <para>List of Regions associated with the hot spot</para>
                /// </summary>
                [NameInMap("Locations")]
                [Validation(Required=false)]
                public List<string> Locations { get; set; }

                /// <summary>
                /// <para>Article List</para>
                /// </summary>
                [NameInMap("News")]
                [Validation(Required=false)]
                public List<GetHotTopicBroadcastResponseBodyDataDataNews> News { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataNews : TeaModel {
                    /// <summary>
                    /// <para>Model categorization result</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科技</para>
                    /// </summary>
                    [NameInMap("AnalysisCategory")]
                    [Validation(Required=false)]
                    public string AnalysisCategory { get; set; }

                    /// <summary>
                    /// <para>aggregated hot spot name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>聚合后热点名称</para>
                    /// </summary>
                    [NameInMap("AnalysisTopic")]
                    [Validation(Required=false)]
                    public string AnalysisTopic { get; set; }

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
                    /// <para>Categorization</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public List<string> Category { get; set; }

                    /// <summary>
                    /// <para>News content</para>
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public List<GetHotTopicBroadcastResponseBodyDataDataNewsComments> Comments { get; set; }
                    public class GetHotTopicBroadcastResponseBodyDataDataNewsComments : TeaModel {
                        /// <summary>
                        /// <para>Content</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>内容</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>Username</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>用户名</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// <para>News content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新闻内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Ingestion time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-06-13 08:45:05</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>Source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>夸克</para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>Date of entry</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024111110</para>
                    /// </summary>
                    [NameInMap("Dt")]
                    [Validation(Required=false)]
                    public string Dt { get; set; }

                    /// <summary>
                    /// <para>original hot spot name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>原始热点名称</para>
                    /// </summary>
                    [NameInMap("HotTopic")]
                    [Validation(Required=false)]
                    public string HotTopic { get; set; }

                    /// <summary>
                    /// <para>Image list</para>
                    /// </summary>
                    [NameInMap("ImgList")]
                    [Validation(Required=false)]
                    public List<string> ImgList { get; set; }

                    /// <summary>
                    /// <para>logo</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com/a.png">https://www.example.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("Logo")]
                    [Validation(Required=false)]
                    public string Logo { get; set; }

                    /// <summary>
                    /// <para>Published At</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-10 12:12:00</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>Summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>title</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>news URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/a.png">http://www.example.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// <para>Primary key ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>主键ID</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <para>website</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>网站</para>
                    /// </summary>
                    [NameInMap("Website")]
                    [Validation(Required=false)]
                    public string Website { get; set; }

                }

                /// <summary>
                /// <para>Output Token</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("OutputToken")]
                [Validation(Required=false)]
                public int? OutputToken { get; set; }

                /// <summary>
                /// <para>Published At</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-01 12:00:00</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <para>Structured summary of hot spot topics</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public GetHotTopicBroadcastResponseBodyDataDataSummary Summary { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataSummary : TeaModel {
                    /// <summary>
                    /// <para>Number of input tokens used to generate this summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("InputToken")]
                    [Validation(Required=false)]
                    public int? InputToken { get; set; }

                    /// <summary>
                    /// <para>Number of output tokens used to generate this summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>41</para>
                    /// </summary>
                    [NameInMap("OutputToken")]
                    [Validation(Required=false)]
                    public int? OutputToken { get; set; }

                    /// <summary>
                    /// <para>List of structured summaries</para>
                    /// </summary>
                    [NameInMap("Summaries")]
                    [Validation(Required=false)]
                    public List<GetHotTopicBroadcastResponseBodyDataDataSummarySummaries> Summaries { get; set; }
                    public class GetHotTopicBroadcastResponseBodyDataDataSummarySummaries : TeaModel {
                        /// <summary>
                        /// <para>Summary</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                        /// <summary>
                        /// <para>title</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

                /// <summary>
                /// <para>Text summary of the hot topic</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点话题文本摘要</para>
                /// </summary>
                [NameInMap("TextSummary")]
                [Validation(Required=false)]
                public string TextSummary { get; set; }

                /// <summary>
                /// <para>Hot list URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/a.html">http://www.example.com/a.html</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>Estimated total number of tokens required for generation</para>
            /// </summary>
            [NameInMap("TotalTokenInfo")]
            [Validation(Required=false)]
            public GetHotTopicBroadcastResponseBodyDataTotalTokenInfo TotalTokenInfo { get; set; }
            public class GetHotTopicBroadcastResponseBodyDataTotalTokenInfo : TeaModel {
                /// <summary>
                /// <para>Total number of hot spots</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("HotTopicCount")]
                [Validation(Required=false)]
                public int? HotTopicCount { get; set; }

                /// <summary>
                /// <para>Estimated number of input tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <para>Estimated number of output tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                /// <summary>
                /// <para>Estimated total word count</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public int? WordCount { get; set; }

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
        /// <para>Fault description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>is successful: true indicates Succeeded, false indicates failed</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
