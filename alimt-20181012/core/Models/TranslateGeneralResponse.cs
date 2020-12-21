// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateGeneralResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public TranslateGeneralResponseData Data { get; set; }
        public class TranslateGeneralResponseData : TeaModel {
            [NameInMap("Translated")]
            [Validation(Required=true)]
            public string Translated { get; set; }
            [NameInMap("WordCount")]
            [Validation(Required=true)]
            public string WordCount { get; set; }
        };

    }

}
