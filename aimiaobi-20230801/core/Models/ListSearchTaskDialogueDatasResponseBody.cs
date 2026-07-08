// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListSearchTaskDialogueDatasResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of articles.</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<ListSearchTaskDialogueDatasResponseBodyArticles> Articles { get; set; }
        public class ListSearchTaskDialogueDatasResponseBodyArticles : TeaModel {
            /// <summary>
            /// <para>The author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>The unique identifier of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("CategoryUuid")]
            [Validation(Required=false)]
            public string CategoryUuid { get; set; }

            /// <summary>
            /// <para>The content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The custom unique ID of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档-自定义的唯一ID</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The document type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>The internal unique identifier of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            /// <summary>
            /// <para>Extension field 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Extend1")]
            [Validation(Required=false)]
            public string Extend1 { get; set; }

            /// <summary>
            /// <para>Extension field 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Extend2")]
            [Validation(Required=false)]
            public string Extend2 { get; set; }

            /// <summary>
            /// <para>Extension field 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Extend3")]
            [Validation(Required=false)]
            public string Extend3 { get; set; }

            /// <summary>
            /// <para>The multi-modal information.</para>
            /// </summary>
            [NameInMap("MultimodalMedias")]
            [Validation(Required=false)]
            public List<ListSearchTaskDialogueDatasResponseBodyArticlesMultimodalMedias> MultimodalMedias { get; set; }
            public class ListSearchTaskDialogueDatasResponseBodyArticlesMultimodalMedias : TeaModel {
                /// <summary>
                /// <para>The URL of the image or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>图片或视频文件地址</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>The unique identifier of the multi-modal data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>多模态数据唯一标识</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The type of the multi-modal data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>多模态数据类型</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

            }

            /// <summary>
            /// <para>The publication time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-25 14:25:59</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新华社</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The summary of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The list of audio files.</para>
        /// </summary>
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public List<ListSearchTaskDialogueDatasResponseBodyAudios> Audios { get; set; }
        public class ListSearchTaskDialogueDatasResponseBodyAudios : TeaModel {
            /// <summary>
            /// <para>The URL of the image or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx">http://xxx</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The unique identifier of the multi-modal data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListSearchTaskDialogueDatasResponseBodyImages> Images { get; set; }
        public class ListSearchTaskDialogueDatasResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The URL of the image or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>图片或视频文件地址</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The unique identifier of the multi-modal data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>多模态数据唯一标识</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The type of the multi-modal data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>多模态数据类型</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

        }

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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether real-time search is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RealtimeSearch")]
        [Validation(Required=false)]
        public bool? RealtimeSearch { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of videos.</para>
        /// </summary>
        [NameInMap("Videos")]
        [Validation(Required=false)]
        public List<ListSearchTaskDialogueDatasResponseBodyVideos> Videos { get; set; }
        public class ListSearchTaskDialogueDatasResponseBodyVideos : TeaModel {
            /// <summary>
            /// <para>The URL of the image or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>图片或视频文件地址</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The unique identifier of the multi-modal data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>多模态数据唯一标识</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The type of the multi-modal data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>多模态数据类型</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

        }

    }

}
