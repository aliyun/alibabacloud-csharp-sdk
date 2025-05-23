// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FreshViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult FreshViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            [NameInMap("HotViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult HotViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("News")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews> News { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>9957175DEDCF49C5ACF7A956B4FD67B2</para>
                        /// </summary>
                        [NameInMap("DocId")]
                        [Validation(Required=false)]
                        public string DocId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("DocUuid")]
                        [Validation(Required=false)]
                        public string DocUuid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://www.example.com/aaa.png">https://www.example.com/aaa.png</a></para>
                        /// </summary>
                        [NameInMap("ImageUrls")]
                        [Validation(Required=false)]
                        public List<string> ImageUrls { get; set; }

                        [NameInMap("PubTime")]
                        [Validation(Required=false)]
                        public string PubTime { get; set; }

                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[&quot;标签1&quot;,&quot;标签2&quot;]</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>文章主题</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUSPENDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimedViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult TimedViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-01-22 10:29</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>新浪</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/news/1.html">http://www.example.com/news/1.html</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>热点主题事件</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("TopicSummaryResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult TopicSummaryResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult : TeaModel {
                [NameInMap("Summaries")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries> Summaries { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries : TeaModel {
                    [NameInMap("DocList")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList> DocList { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList : TeaModel {
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

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

            [NameInMap("WebReviewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult WebReviewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments> Comments { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>来源</para>
                        /// </summary>
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>评论内容</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>当前评论所属的URL</para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>评论用户名</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

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
