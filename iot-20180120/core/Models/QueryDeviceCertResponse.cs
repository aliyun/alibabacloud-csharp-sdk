// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceCertResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("DeviceCertInfo")]
        [Validation(Required=true)]
        public QueryDeviceCertResponseDeviceCertInfo DeviceCertInfo { get; set; }
        public class QueryDeviceCertResponseDeviceCertInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }
            [NameInMap("Certificate")]
            [Validation(Required=true)]
            public string Certificate { get; set; }
            [NameInMap("PrivateKey")]
            [Validation(Required=true)]
            public string PrivateKey { get; set; }
            [NameInMap("CertSN")]
            [Validation(Required=true)]
            public string CertSN { get; set; }
        };

    }

}
