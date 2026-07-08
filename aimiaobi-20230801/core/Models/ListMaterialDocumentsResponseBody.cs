// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListMaterialDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>List object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMaterialDocumentsResponseBodyData> Data { get; set; }
        public class ListMaterialDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1&quot;</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Creator username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>创建用户名</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>Document tags used for categorization. Separate keywords with commas.</para>
            /// </summary>
            [NameInMap("DocKeywords")]
            [Validation(Required=false)]
            public List<string> DocKeywords { get; set; }

            /// <summary>
            /// <para>Document type: pdf, word, url, or image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>URL uploaded by an external customer, used only for record keeping.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("ExternalUrl")]
            [Validation(Required=false)]
            public string ExternalUrl { get; set; }

            /// <summary>
            /// <para>Media file properties.</para>
            /// </summary>
            [NameInMap("FileAttr")]
            [Validation(Required=false)]
            public ListMaterialDocumentsResponseBodyDataFileAttr FileAttr { get; set; }
            public class ListMaterialDocumentsResponseBodyDataFileAttr : TeaModel {
                /// <summary>
                /// <para>Duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>File content length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("FileLength")]
                [Validation(Required=false)]
                public long? FileLength { get; set; }

                /// <summary>
                /// <para>File name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.mp4</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>Video height.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>File MIME type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>Video width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>Unique file identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://default/oss-bucket-name/aimiaobi/2021/07/01/1625126400000/1.docx</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <para>Web page content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>网页内容</para>
            /// </summary>
            [NameInMap("HtmlContent")]
            [Validation(Required=false)]
            public string HtmlContent { get; set; }

            /// <summary>
            /// <para>Primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Publish time. Format: yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>Temporary public URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

            /// <summary>
            /// <para>Public property, stored by bit. The first bit indicates if it is shared within the workspace, the second bit indicates if it is shared within the tenant, and the third bit indicates if it is shared system-wide.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShareAttr")]
            [Validation(Required=false)]
            public int? ShareAttr { get; set; }

            /// <summary>
            /// <para>Document source: user_upload, search, or viewpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_upload</para>
            /// </summary>
            [NameInMap("SrcFrom")]
            [Validation(Required=false)]
            public string SrcFrom { get; set; }

            /// <summary>
            /// <para>Document summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>Parsed text content. This is empty for images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档内容</para>
            /// </summary>
            [NameInMap("TextContent")]
            [Validation(Required=false)]
            public string TextContent { get; set; }

            /// <summary>
            /// <para>Base64 thumbnail for image document types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>base64编码的图像二进制数据</para>
            /// </summary>
            [NameInMap("ThumbnailInBase64")]
            [Validation(Required=false)]
            public string ThumbnailInBase64 { get; set; }

            /// <summary>
            /// <para>Document title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Modifier user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1&quot;</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            /// <summary>
            /// <para>The name of the user who updated the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>更新用户名</para>
            /// </summary>
            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            /// <summary>
            /// <para>URL for internal document storage. Supports multiple protocols (http\://, file://, ftp\://). This URL is saved to internal storage when a customer uploads a file, stored long-term, and deleted upon expiration.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Is successful: true for success, false for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
