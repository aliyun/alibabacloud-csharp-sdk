// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomSourceTopicAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The types of analysis for hot topic selection. Multiple values are supported. If you omit this parameter, the service analyzes all types by default. If you pass an empty array, the service performs only clustering and skips the analysis of hot topics for selection.
        /// <c>HotViewPoints</c>: Analyzes perspectives on hot topics.
        /// <c>WebReviewPoints</c>: Analyzes user viewpoints. This requires comments.
        /// <c>TimedViewPoints</c>: Analyzes perspectives on timeliness.
        /// <c>FreshViewPoints</c>: Analyzes novel perspectives.
        /// <c>TopicSummary</c>: Summarizes news content.</para>
        /// </summary>
        [NameInMap("AnalysisTypes")]
        [Validation(Required=false)]
        public List<string> AnalysisTypes { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: <c>json</c> (JSON array) and <c>jsonLine</c> (JSON Lines).</para>
        /// 
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The file URL. You must specify either <c>FileUrl</c> or <c>News</c>. For details on the file structure, see the description of the <c>News</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx.json">http://www.example.com/xxx.json</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The maximum number of topics to analyze. By default, the service sorts clustered news by count in descending order and analyzes the top 50 topics. The maximum value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxTopicSize")]
        [Validation(Required=false)]
        public int? MaxTopicSize { get; set; }

        /// <summary>
        /// <para>A list of news articles. You must specify either <c>News</c> or <c>FileUrl</c>.</para>
        /// </summary>
        [NameInMap("News")]
        [Validation(Required=false)]
        public List<SubmitCustomSourceTopicAnalysisRequestNews> News { get; set; }
        public class SubmitCustomSourceTopicAnalysisRequestNews : TeaModel {
            /// <summary>
            /// <para>A list of comments.</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public List<SubmitCustomSourceTopicAnalysisRequestNewsComments> Comments { get; set; }
            public class SubmitCustomSourceTopicAnalysisRequestNewsComments : TeaModel {
                /// <summary>
                /// <para>The comment text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>评论内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The content of the news article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新闻正文</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The publication time. The format must be <c>YYYY-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-22 10:29:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The source of the news article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>百度</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The title of the news article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新闻标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the news article.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com/xxx.html">http://www.example.com/xxx.html</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>A list of topics.</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<SubmitCustomSourceTopicAnalysisRequestTopics> Topics { get; set; }
        public class SubmitCustomSourceTopicAnalysisRequestTopics : TeaModel {
            /// <summary>
            /// <para>A custom field. You can use this field to filter results when you call the <c>ListHotTopics</c> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CustomField")]
            [Validation(Required=false)]
            public string CustomField { get; set; }

            /// <summary>
            /// <para>A list of news articles.</para>
            /// </summary>
            [NameInMap("News")]
            [Validation(Required=false)]
            public List<HottopicNews> News { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>话题名称</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The URL of the topic. This value is passed through to the <c>ListHotTopics</c> response without being processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/topic/123">https://www.example.com/topic/123</a></para>
            /// </summary>
            [NameInMap("TopicUrl")]
            [Validation(Required=false)]
            public string TopicUrl { get; set; }

        }

        /// <summary>
        /// <para>The URL of the file that contains the topic list. The file must be in JSON Lines format, with each line representing a single JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx.jsonline">http://www.example.com/xxx.jsonline</a></para>
        /// </summary>
        [NameInMap("TopicsFileUrl")]
        [Validation(Required=false)]
        public string TopicsFileUrl { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The Model Studio workspace ID.</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
