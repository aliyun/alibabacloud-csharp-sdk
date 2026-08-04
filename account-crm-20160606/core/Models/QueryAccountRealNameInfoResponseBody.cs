// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountRealNameInfoResponseBody : TeaModel {
        [NameInMap("ProfileInfo")]
        [Validation(Required=false)]
        public QueryAccountRealNameInfoResponseBodyProfileInfo ProfileInfo { get; set; }
        public class QueryAccountRealNameInfoResponseBodyProfileInfo : TeaModel {
            [NameInMap("AccountCertifyType")]
            [Validation(Required=false)]
            public string AccountCertifyType { get; set; }

            [NameInMap("AuthAlipay")]
            [Validation(Required=false)]
            public string AuthAlipay { get; set; }

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

            [NameInMap("IsBankIDAuth")]
            [Validation(Required=false)]
            public string IsBankIDAuth { get; set; }

            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public string IsCertified { get; set; }

            [NameInMap("LicenseNumber")]
            [Validation(Required=false)]
            public string LicenseNumber { get; set; }

            [NameInMap("LicenseType")]
            [Validation(Required=false)]
            public string LicenseType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProcessingEnterpriseCertify")]
            [Validation(Required=false)]
            public bool? ProcessingEnterpriseCertify { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
