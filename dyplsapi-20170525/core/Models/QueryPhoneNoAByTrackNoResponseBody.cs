// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryPhoneNoAByTrackNoResponseBodyModule Module { get; set; }
        public class QueryPhoneNoAByTrackNoResponseBodyModule : TeaModel {
            [NameInMap("phoneNoAInfo")]
            [Validation(Required=false)]
            public List<QueryPhoneNoAByTrackNoResponseBodyModulePhoneNoAInfo> PhoneNoAInfo { get; set; }
            public class QueryPhoneNoAByTrackNoResponseBodyModulePhoneNoAInfo : TeaModel {
                public string PhoneNoX { get; set; }
                public string PhoneNoA { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
