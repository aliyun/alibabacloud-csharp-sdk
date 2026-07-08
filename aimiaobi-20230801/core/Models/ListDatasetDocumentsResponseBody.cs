// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListDatasetDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A list of documents.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDatasetDocumentsResponseBodyData> Data { get; set; }
        public class ListDatasetDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("CategoryUuid")]
            [Validation(Required=false)]
            public string CategoryUuid { get; set; }

            /// <summary>
            /// <para>The content of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-14 19:59:53</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Indicates whether multimodal indexing is disabled for this document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

            /// <summary>
            /// <para>The user-specified unique document ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The type of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>The unique internal document ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>内部文档唯一ID</para>
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
            /// <para>A list of multimodal media items associated with the document.</para>
            /// </summary>
            [NameInMap("MultimodalMedias")]
            [Validation(Required=false)]
            public List<ListDatasetDocumentsResponseBodyDataMultimodalMedias> MultimodalMedias { get; set; }
            public class ListDatasetDocumentsResponseBodyDataMultimodalMedias : TeaModel {
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
                /// <para>The unique ID of the multimodal media.</para>
                /// 
                /// <b>Example:</b>
                /// <para>多模态数据唯一标识</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The type of the multimodal media.</para>
                /// 
                /// <b>Example:</b>
                /// <para>多模态数据类型</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

            }

            /// <summary>
            /// <para>The publication time of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The source of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>来源</para>
            /// </summary>
            [NameInMap("SourceFrom")]
            [Validation(Required=false)]
            public string SourceFrom { get; set; }

            /// <summary>
            /// <para>The build status of the document index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The summary of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>A list of tags associated with the document.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The title of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The last update time of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-14 19:59:53</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user who last updated the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            /// <summary>
            /// <para>The URL of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx/xx">https://xxx/xx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

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
        /// <para>A detailed message about the request status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. This field appears only when more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of <c>true</c> indicates success, and <c>false</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of matching documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
