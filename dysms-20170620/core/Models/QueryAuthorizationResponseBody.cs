// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryAuthorizationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryAuthorizationResponseBodyResult> Result { get; set; }
        public class QueryAuthorizationResponseBodyResult : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public long? AliyunUid { get; set; }

            [NameInMap("AuthorizeCode")]
            [Validation(Required=false)]
            public string AuthorizeCode { get; set; }

            [NameInMap("AuthorizeStatus")]
            [Validation(Required=false)]
            public bool? AuthorizeStatus { get; set; }

            [NameInMap("AuthorizeTime")]
            [Validation(Required=false)]
            public string AuthorizeTime { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("UnAuthorizeTime")]
            [Validation(Required=false)]
            public string UnAuthorizeTime { get; set; }

        }

    }

}
