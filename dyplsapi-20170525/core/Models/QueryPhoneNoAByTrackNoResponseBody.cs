// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<QueryPhoneNoAByTrackNoResponseBodyModule> Module { get; set; }
        public class QueryPhoneNoAByTrackNoResponseBodyModule : TeaModel {
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
