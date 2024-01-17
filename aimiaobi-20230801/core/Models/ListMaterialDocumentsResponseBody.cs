// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListMaterialDocumentsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DocKeywords")]
            [Validation(Required=false)]
            public List<string> DocKeywords { get; set; }

            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            [NameInMap("ExternalUrl")]
            [Validation(Required=false)]
            public string ExternalUrl { get; set; }

            [NameInMap("HtmlContent")]
            [Validation(Required=false)]
            public string HtmlContent { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

            [NameInMap("ShareAttr")]
            [Validation(Required=false)]
            public int? ShareAttr { get; set; }

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

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
