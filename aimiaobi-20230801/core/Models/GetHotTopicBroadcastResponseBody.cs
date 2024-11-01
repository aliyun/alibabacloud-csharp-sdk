// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetHotTopicBroadcastResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotTopicBroadcastResponseBodyData Data { get; set; }
        public class GetHotTopicBroadcastResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetHotTopicBroadcastResponseBodyDataData> Data { get; set; }
            public class GetHotTopicBroadcastResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>热点话题分类</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建时间</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34.7905341705522</para>
                /// </summary>
                [NameInMap("CustomHotValue")]
                [Validation(Required=false)]
                public double? CustomHotValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>自定义热点话题文本摘要</para>
                /// </summary>
                [NameInMap("CustomTextSummary")]
                [Validation(Required=false)]
                public string CustomTextSummary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热点话题名称</para>
                /// </summary>
                [NameInMap("HotTopic")]
                [Validation(Required=false)]
                public string HotTopic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热点话题摘要版本</para>
                /// </summary>
                [NameInMap("HotTopicVersion")]
                [Validation(Required=false)]
                public string HotTopicVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.4120480606282884</para>
                /// </summary>
                [NameInMap("HotValue")]
                [Validation(Required=false)]
                public double? HotValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热点话题ID</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Images")]
                [Validation(Required=false)]
                public List<GetHotTopicBroadcastResponseBodyDataDataImages> Images { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataImages : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/a.png">http://www.example.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("InputToken")]
                [Validation(Required=false)]
                public int? InputToken { get; set; }

                [NameInMap("News")]
                [Validation(Required=false)]
                public List<GetHotTopicBroadcastResponseBodyDataDataNews> News { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataNews : TeaModel {
                    [NameInMap("AnalysisCategory")]
                    [Validation(Required=false)]
                    public string AnalysisCategory { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>聚合后热点名称</para>
                    /// </summary>
                    [NameInMap("AnalysisTopic")]
                    [Validation(Required=false)]
                    public string AnalysisTopic { get; set; }

                    [NameInMap("Author")]
                    [Validation(Required=false)]
                    public string Author { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public List<string> Category { get; set; }

                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public List<GetHotTopicBroadcastResponseBodyDataDataNewsComments> Comments { get; set; }
                    public class GetHotTopicBroadcastResponseBodyDataDataNewsComments : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>评论内容</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>评论用户名</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-06-13 08:45:05</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024111110</para>
                    /// </summary>
                    [NameInMap("Dt")]
                    [Validation(Required=false)]
                    public string Dt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>原始热点名称</para>
                    /// </summary>
                    [NameInMap("HotTopic")]
                    [Validation(Required=false)]
                    public string HotTopic { get; set; }

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
                    /// <b>Example:</b>
                    /// <para>2024-10-10 12:12:00</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/a.png">http://www.example.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>主键ID</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>网站</para>
                    /// </summary>
                    [NameInMap("Website")]
                    [Validation(Required=false)]
                    public string Website { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("OutputToken")]
                [Validation(Required=false)]
                public int? OutputToken { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public GetHotTopicBroadcastResponseBodyDataDataSummary Summary { get; set; }
                public class GetHotTopicBroadcastResponseBodyDataDataSummary : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("InputToken")]
                    [Validation(Required=false)]
                    public int? InputToken { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>41</para>
                    /// </summary>
                    [NameInMap("OutputToken")]
                    [Validation(Required=false)]
                    public int? OutputToken { get; set; }

                    [NameInMap("Summaries")]
                    [Validation(Required=false)]
                    public List<GetHotTopicBroadcastResponseBodyDataDataSummarySummaries> Summaries { get; set; }
                    public class GetHotTopicBroadcastResponseBodyDataDataSummarySummaries : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热点话题文本摘要</para>
                /// </summary>
                [NameInMap("TextSummary")]
                [Validation(Required=false)]
                public string TextSummary { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalTokenInfo")]
            [Validation(Required=false)]
            public GetHotTopicBroadcastResponseBodyDataTotalTokenInfo TotalTokenInfo { get; set; }
            public class GetHotTopicBroadcastResponseBodyDataTotalTokenInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("HotTopicCount")]
                [Validation(Required=false)]
                public int? HotTopicCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public int? WordCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
