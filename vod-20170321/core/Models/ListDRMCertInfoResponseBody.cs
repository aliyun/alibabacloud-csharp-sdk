// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListDRMCertInfoResponseBody : TeaModel {
        [NameInMap("DRMCertInfoList")]
        [Validation(Required=false)]
        public List<ListDRMCertInfoResponseBodyDRMCertInfoList> DRMCertInfoList { get; set; }
        public class ListDRMCertInfoResponseBodyDRMCertInfoList : TeaModel {
            [NameInMap("Ask")]
            [Validation(Required=false)]
            public string Ask { get; set; }

            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DRMType")]
            [Validation(Required=false)]
            public string DRMType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("PassPhrase")]
            [Validation(Required=false)]
            public string PassPhrase { get; set; }

            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

            [NameInMap("ServCert")]
            [Validation(Required=false)]
            public string ServCert { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
