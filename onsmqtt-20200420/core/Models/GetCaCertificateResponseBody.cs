// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class GetCaCertificateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCaCertificateResponseBodyData Data { get; set; }
        public class GetCaCertificateResponseBodyData : TeaModel {
            [NameInMap("CaContent")]
            [Validation(Required=false)]
            public string CaContent { get; set; }

            [NameInMap("CaName")]
            [Validation(Required=false)]
            public string CaName { get; set; }

            [NameInMap("RegistrationCode")]
            [Validation(Required=false)]
            public string RegistrationCode { get; set; }

            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ValidBegin")]
            [Validation(Required=false)]
            public string ValidBegin { get; set; }

            [NameInMap("ValidEnd")]
            [Validation(Required=false)]
            public string ValidEnd { get; set; }

            [NameInMap("VerificationContent")]
            [Validation(Required=false)]
            public string VerificationContent { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
