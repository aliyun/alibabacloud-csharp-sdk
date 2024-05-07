// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetVerificationInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEmailDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityEmailDevice SecurityEmailDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityEmailDevice : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("SecurityPhoneDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityPhoneDevice SecurityPhoneDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityPhoneDevice : TeaModel {
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
