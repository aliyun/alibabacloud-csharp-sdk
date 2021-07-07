// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CreateSipAccountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSipAccountResponseBodyData Data { get; set; }
        public class CreateSipAccountResponseBodyData : TeaModel {
            [NameInMap("SipAccountID")]
            [Validation(Required=false)]
            public string SipAccountID { get; set; }
            [NameInMap("VoipName")]
            [Validation(Required=false)]
            public string VoipName { get; set; }
            [NameInMap("VoipPassword")]
            [Validation(Required=false)]
            public string VoipPassword { get; set; }
        };

    }

}
