// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetAppConfigResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAppConfigResponseBodyData Data { get; set; }
        public class GetAppConfigResponseBodyData : TeaModel {
            [NameInMap("embeddingTypeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> EmbeddingTypeList { get; set; }

            [NameInMap("frontendConfig")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> FrontendConfig { get; set; }

            [NameInMap("libraryDocumentStatusList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> LibraryDocumentStatusList { get; set; }

            [NameInMap("llmHelperTypeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> LlmHelperTypeList { get; set; }

            [NameInMap("textIndexCategoryList")]
            [Validation(Required=false)]
            public List<string> TextIndexCategoryList { get; set; }

            [NameInMap("vectorIndexCategoryList")]
            [Validation(Required=false)]
            public List<string> VectorIndexCategoryList { get; set; }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
