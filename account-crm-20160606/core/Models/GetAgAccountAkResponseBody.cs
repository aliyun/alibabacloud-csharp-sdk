// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetAgAccountAkResponseBody : TeaModel {
        [NameInMap("AccountAkDto")]
        [Validation(Required=false)]
        public GetAgAccountAkResponseBodyAccountAkDto AccountAkDto { get; set; }
        public class GetAgAccountAkResponseBodyAccountAkDto : TeaModel {
            [NameInMap("Ak")]
            [Validation(Required=false)]
            public string Ak { get; set; }

            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
