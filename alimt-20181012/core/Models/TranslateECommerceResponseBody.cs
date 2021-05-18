// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateECommerceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateECommerceResponseBodyData Data { get; set; }
        public class TranslateECommerceResponseBodyData : TeaModel {
            [NameInMap("Translated")]
            [Validation(Required=false)]
            public string Translated { get; set; }
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }
        };

    }

}
