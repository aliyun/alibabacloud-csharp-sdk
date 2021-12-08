// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSubscriptionDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionDetailResponseBodyData Data { get; set; }
        public class GetSubscriptionDetailResponseBodyData : TeaModel {
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }
            [NameInMap("PhoneNo")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public long? SubsId { get; set; }
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public int? SwitchStatus { get; set; }
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
