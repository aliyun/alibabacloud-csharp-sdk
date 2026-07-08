// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The analysis result of novel topic selection perspectives.</para>
            /// </summary>
            [NameInMap("FreshViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult FreshViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult : TeaModel {
                /// <summary>
                /// <para>A list of viewpoints for novel topic selection perspectives.</para>
                /// </summary>
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <para>The current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <para>The type of the viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <para>The proportion of the current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <para>A list of topic selection perspectives.</para>
                    /// </summary>
                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints : TeaModel {
                        /// <summary>
                        /// <para>The outline.</para>
                        /// </summary>
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <para>The outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <para>The summary of the outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <para>The generated perspective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <para>The summary.</para>
                        /// 
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
            /// <para>The analysis result of hot topic selection perspectives.</para>
            /// </summary>
            [NameInMap("HotViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult HotViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult : TeaModel {
                /// <summary>
                /// <para>A list of viewpoints for hot topic selection perspectives.</para>
                /// </summary>
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <para>The current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <para>The type of the viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <para>A list of related news.</para>
                    /// </summary>
                    [NameInMap("News")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews> News { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews : TeaModel {
                        /// <summary>
                        /// <para>The news content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Content</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The time when the article was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-05-08 02:23:01</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>The custom unique ID of the document.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9957175DEDCF49C5ACF7A956B4FD67B2</para>
                        /// </summary>
                        [NameInMap("DocId")]
                        [Validation(Required=false)]
                        public string DocId { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;123456&quot;</para>
                        /// </summary>
                        [NameInMap("DocUuid")]
                        [Validation(Required=false)]
                        public string DocUuid { get; set; }

                        /// <summary>
                        /// <para>The URLs of the images in the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://www.example.com/aaa.png">https://www.example.com/aaa.png</a></para>
                        /// </summary>
                        [NameInMap("ImageUrls")]
                        [Validation(Required=false)]
                        public List<string> ImageUrls { get; set; }

                        /// <summary>
                        /// <para>The time when the article was published.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-05-08 02:23:02</para>
                        /// </summary>
                        [NameInMap("PubTime")]
                        [Validation(Required=false)]
                        public string PubTime { get; set; }

                        /// <summary>
                        /// <para>The source of the news.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>夸克</para>
                        /// </summary>
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <para>The summary of the news.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>新闻摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                        /// <summary>
                        /// <para>The tags.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;标签1&quot;,&quot;标签2&quot;]</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

                        /// <summary>
                        /// <para>The title of the news.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>新闻标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The topic of the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>文章主题</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <para>The URL of the news.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The proportion of the current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <para>A list of topic selection perspectives.</para>
                    /// </summary>
                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints : TeaModel {
                        /// <summary>
                        /// <para>The outline.</para>
                        /// </summary>
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <para>The outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <para>The summary of the outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <para>The generated perspective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <para>The summary.</para>
                        /// 
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
            /// <para>The status of the task. Valid values: PENDING, RUNNING, SUCCESSED, SUSPENDED, FAILED, and CANCELED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUSPENDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The analysis result of time-sensitive topic selection perspectives.</para>
            /// </summary>
            [NameInMap("TimedViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult TimedViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult : TeaModel {
                /// <summary>
                /// <para>A list of viewpoints for time-sensitive topic selection perspectives.</para>
                /// </summary>
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <para>The current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <para>The type of the viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <para>The time when the viewpoint was published.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-01-22 10:29</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>The proportion of the current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <para>The source of the news.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新浪</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The current viewpoint. This is the same as the news title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The URL of the news.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/news/1.html">http://www.example.com/news/1.html</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// <para>A list of topic selection perspectives.</para>
                    /// </summary>
                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints : TeaModel {
                        /// <summary>
                        /// <para>The outline.</para>
                        /// </summary>
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <para>The outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <para>The summary of the outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <para>The generated perspective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <para>The summary.</para>
                        /// 
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
            /// <para>The hot spot topic event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>热点主题事件</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The summary of the hot spot topic event.</para>
            /// </summary>
            [NameInMap("TopicSummaryResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult TopicSummaryResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult : TeaModel {
                /// <summary>
                /// <para>A list of summaries.</para>
                /// </summary>
                [NameInMap("Summaries")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries> Summaries { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries : TeaModel {
                    /// <summary>
                    /// <para>The articles referenced to generate the summary for this title.</para>
                    /// </summary>
                    [NameInMap("DocList")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList> DocList { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList : TeaModel {
                        /// <summary>
                        /// <para>The source of the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>头条</para>
                        /// </summary>
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <para>The title of the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The URL of the article.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>The title.</para>
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
            /// <para>The analysis result of online review topic selection perspectives.</para>
            /// </summary>
            [NameInMap("WebReviewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult WebReviewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult : TeaModel {
                /// <summary>
                /// <para>A list of viewpoints from online reviews for topic selection.</para>
                /// </summary>
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <para>The current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <para>The type of the viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <para>A list of user comments.</para>
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments> Comments { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments : TeaModel {
                        /// <summary>
                        /// <para>The source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>来源</para>
                        /// </summary>
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <para>The content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>内容</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>标题</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The URL where the comment is located.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>当前所属的URL</para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>用户名</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// <para>The proportion of the current viewpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <para>A list of topic selection perspectives.</para>
                    /// </summary>
                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints : TeaModel {
                        /// <summary>
                        /// <para>The outline.</para>
                        /// </summary>
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <para>The outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <para>The summary of the outline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <para>The generated perspective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <para>The summary.</para>
                        /// 
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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
