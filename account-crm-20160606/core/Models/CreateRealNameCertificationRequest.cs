// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class CreateRealNameCertificationRequest : TeaModel {
        [NameInMap("AccountCertifyType")]
        [Validation(Required=false)]
        public string AccountCertifyType { get; set; }

        [NameInMap("CorporateLicenseNumber")]
        [Validation(Required=false)]
        public string CorporateLicenseNumber { get; set; }

        [NameInMap("CorporateName")]
        [Validation(Required=false)]
        public string CorporateName { get; set; }

        [NameInMap("LicenseNumber")]
        [Validation(Required=false)]
        public string LicenseNumber { get; set; }

        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

    }

}
