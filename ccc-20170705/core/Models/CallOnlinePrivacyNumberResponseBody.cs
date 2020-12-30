// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CallOnlinePrivacyNumberResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CallOnlinePrivacyNumberResponseBodyData Data { get; set; }
        public class CallOnlinePrivacyNumberResponseBodyData : TeaModel {
            [NameInMap("Represent")]
            [Validation(Required=false)]
            public string Represent { get; set; }
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }
            [NameInMap("DateCreated")]
            [Validation(Required=false)]
            public string DateCreated { get; set; }
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
