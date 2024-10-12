// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListMaterialDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMaterialDocumentsResponseBodyData> Data { get; set; }
        public class ListMaterialDocumentsResponseBodyData : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DocKeywords")]
            [Validation(Required=false)]
            public List<string> DocKeywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("ExternalUrl")]
            [Validation(Required=false)]
            public string ExternalUrl { get; set; }

            [NameInMap("HtmlContent")]
            [Validation(Required=false)]
            public string HtmlContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>35</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShareAttr")]
            [Validation(Required=false)]
            public int? ShareAttr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_upload</para>
            /// </summary>
            [NameInMap("SrcFrom")]
            [Validation(Required=false)]
            public string SrcFrom { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("TextContent")]
            [Validation(Required=false)]
            public string TextContent { get; set; }

            [NameInMap("ThumbnailInBase64")]
            [Validation(Required=false)]
            public string ThumbnailInBase64 { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-18 02:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

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
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
