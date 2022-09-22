// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class GetDocumentConvertResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Completed")]
        [Validation(Required=false)]
        public bool? Completed { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDocumentConvertResultResponseBodyData> Data { get; set; }
        public class GetDocumentConvertResultResponseBodyData : TeaModel {
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
