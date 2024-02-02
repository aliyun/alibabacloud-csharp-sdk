// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryPhoneNumberOnlineTimeResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneNumberOnlineTimeResponseBodyData Data { get; set; }
        public class QueryPhoneNumberOnlineTimeResponseBodyData : TeaModel {
            [NameInMap("CarrierCode")]
            [Validation(Required=false)]
            public string CarrierCode { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public long? VerifyResult { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
