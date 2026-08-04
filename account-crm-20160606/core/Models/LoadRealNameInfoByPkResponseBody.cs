// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class LoadRealNameInfoByPkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public LoadRealNameInfoByPkResponseBodyData Data { get; set; }
        public class LoadRealNameInfoByPkResponseBodyData : TeaModel {
            [NameInMap("AccountCertifyType")]
            [Validation(Required=false)]
            public string AccountCertifyType { get; set; }

            [NameInMap("AuthAlipay")]
            [Validation(Required=false)]
            public string AuthAlipay { get; set; }

            [NameInMap("AuthAlipayDomain")]
            [Validation(Required=false)]
            public string AuthAlipayDomain { get; set; }

            [NameInMap("AuthAlipayLoginId")]
            [Validation(Required=false)]
            public string AuthAlipayLoginId { get; set; }

            [NameInMap("AuthBeiAnCid")]
            [Validation(Required=false)]
            public string AuthBeiAnCid { get; set; }

            [NameInMap("AuthDomain")]
            [Validation(Required=false)]
            public string AuthDomain { get; set; }

            [NameInMap("CertifiedFrom")]
            [Validation(Required=false)]
            public string CertifiedFrom { get; set; }

            [NameInMap("CertifiedTime")]
            [Validation(Required=false)]
            public string CertifiedTime { get; set; }

            [NameInMap("CertifyStatus")]
            [Validation(Required=false)]
            public int? CertifyStatus { get; set; }

            [NameInMap("CicCertifyFrom")]
            [Validation(Required=false)]
            public int? CicCertifyFrom { get; set; }

            [NameInMap("CicCertifyProduct")]
            [Validation(Required=false)]
            public long? CicCertifyProduct { get; set; }

            [NameInMap("IsBankIDAuth")]
            [Validation(Required=false)]
            public bool? IsBankIDAuth { get; set; }

            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public bool? IsCertified { get; set; }

            [NameInMap("LicenseNumber")]
            [Validation(Required=false)]
            public string LicenseNumber { get; set; }

            [NameInMap("LicenseType")]
            [Validation(Required=false)]
            public string LicenseType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NewUnityRealNameAccount")]
            [Validation(Required=false)]
            public string NewUnityRealNameAccount { get; set; }

            [NameInMap("ProcessingEnterpriseCertify")]
            [Validation(Required=false)]
            public bool? ProcessingEnterpriseCertify { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
