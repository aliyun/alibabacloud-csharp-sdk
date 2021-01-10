// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryVoiceIntercomResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryVoiceIntercomResponseBodyData Data { get; set; }
        public class QueryVoiceIntercomResponseBodyData : TeaModel {
            [NameInMap("CryptoKey")]
            [Validation(Required=false)]
            public QueryVoiceIntercomResponseBodyDataCryptoKey CryptoKey { get; set; }
            public class QueryVoiceIntercomResponseBodyDataCryptoKey : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Iv")]
                [Validation(Required=false)]
                public string Iv { get; set; }

            }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
