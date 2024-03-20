// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListCaCertificateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCaCertificateResponseBodyData Data { get; set; }
        public class ListCaCertificateResponseBodyData : TeaModel {
            [NameInMap("CaCertificateVOS")]
            [Validation(Required=false)]
            public List<ListCaCertificateResponseBodyDataCaCertificateVOS> CaCertificateVOS { get; set; }
            public class ListCaCertificateResponseBodyDataCaCertificateVOS : TeaModel {
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

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
