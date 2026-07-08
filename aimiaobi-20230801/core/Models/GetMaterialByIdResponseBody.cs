// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetMaterialByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMaterialByIdResponseBodyData Data { get; set; }
        public class GetMaterialByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Author</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-21 11:34:19</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator user ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Document tags used for classification and other purposes. Separate multiple keywords with commas.</para>
            /// </summary>
            [NameInMap("DocKeywords")]
            [Validation(Required=false)]
            public List<string> DocKeywords { get; set; }

            /// <summary>
            /// <para>Document type, such as pdf, word, url, or image</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>URL uploaded by an external customer. Used only for record keeping.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("ExternalUrl")]
            [Validation(Required=false)]
            public string ExternalUrl { get; set; }

            /// <summary>
            /// <para>Web page content</para>
            /// 
            /// <b>Example:</b>
            /// <para>网页内容</para>
            /// </summary>
            [NameInMap("HtmlContent")]
            [Validation(Required=false)]
            public string HtmlContent { get; set; }

            /// <summary>
            /// <para>Primary key</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Publication time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-11 06:14:07</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>Temporary public URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

            /// <summary>
            /// <para>Sharing attribute stored as bit flags. The first bit indicates sharing within the workspace, the second bit indicates sharing within the tenant, and the third bit indicates system-wide sharing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShareAttr")]
            [Validation(Required=false)]
            public int? ShareAttr { get; set; }

            /// <summary>
            /// <para>Document source, such as user_upload, search, or viewpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_upload</para>
            /// </summary>
            [NameInMap("SrcFrom")]
            [Validation(Required=false)]
            public string SrcFrom { get; set; }

            /// <summary>
            /// <para>Document summary</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>Parsed text content. Empty for images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文本内容</para>
            /// </summary>
            [NameInMap("TextContent")]
            [Validation(Required=false)]
            public string TextContent { get; set; }

            /// <summary>
            /// <para>Base64-encoded thumbnail for image documents</para>
            /// 
            /// <b>Example:</b>
            /// <para>Base64编码的缩略图</para>
            /// </summary>
            [NameInMap("ThumbnailInBase64")]
            [Validation(Required=false)]
            public string ThumbnailInBase64 { get; set; }

            /// <summary>
            /// <para>Document title</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Modification time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-08 19:33:01</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Modifier user ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            /// <summary>
            /// <para>Internal document storage URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

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
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
