// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceCertResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DeviceCertInfo")]
        [Validation(Required=false)]
        public QueryDeviceCertResponseBodyDeviceCertInfo DeviceCertInfo { get; set; }
        public class QueryDeviceCertResponseBodyDeviceCertInfo : TeaModel {
            [NameInMap("CertSN")]
            [Validation(Required=false)]
            public string CertSN { get; set; }

            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
