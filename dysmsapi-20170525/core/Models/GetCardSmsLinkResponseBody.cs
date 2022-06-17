// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardSmsLinkResponseBodyData Data { get; set; }
        public class GetCardSmsLinkResponseBodyData : TeaModel {
            [NameInMap("CardPhoneNumbers")]
            [Validation(Required=false)]
            public string CardPhoneNumbers { get; set; }
            [NameInMap("CardSignNames")]
            [Validation(Required=false)]
            public string CardSignNames { get; set; }
            [NameInMap("CardSmsLinks")]
            [Validation(Required=false)]
            public string CardSmsLinks { get; set; }
            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }
            [NameInMap("NotMediaMobiles")]
            [Validation(Required=false)]
            public string NotMediaMobiles { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
