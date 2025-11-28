// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class QueryBlockchainDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBlockchainDataResponseBodyData Data { get; set; }
        public class QueryBlockchainDataResponseBodyData : TeaModel {
            [NameInMap("AlgType")]
            [Validation(Required=false)]
            public string AlgType { get; set; }

            [NameInMap("PlainData")]
            [Validation(Required=false)]
            public string PlainData { get; set; }

            [NameInMap("PrivacyData")]
            [Validation(Required=false)]
            public string PrivacyData { get; set; }

            [NameInMap("PrivacyRuleId")]
            [Validation(Required=false)]
            public string PrivacyRuleId { get; set; }

        }

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
