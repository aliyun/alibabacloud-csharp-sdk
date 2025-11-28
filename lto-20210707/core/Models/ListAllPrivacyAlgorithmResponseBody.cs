// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListAllPrivacyAlgorithmResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllPrivacyAlgorithmResponseBodyData> Data { get; set; }
        public class ListAllPrivacyAlgorithmResponseBodyData : TeaModel {
            [NameInMap("AlgImplList")]
            [Validation(Required=false)]
            public List<string> AlgImplList { get; set; }

            [NameInMap("AlgType")]
            [Validation(Required=false)]
            public string AlgType { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
