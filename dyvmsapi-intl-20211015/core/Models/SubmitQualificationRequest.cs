// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class SubmitQualificationRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("BusinessLicenseFileKey")]
        [Validation(Required=false)]
        public string BusinessLicenseFileKey { get; set; }

        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        [NameInMap("LegalId")]
        [Validation(Required=false)]
        public string LegalId { get; set; }

        [NameInMap("LegalLicenseFileKey")]
        [Validation(Required=false)]
        public string LegalLicenseFileKey { get; set; }

        [NameInMap("LegalName")]
        [Validation(Required=false)]
        public string LegalName { get; set; }

        [NameInMap("NetworkAccessFileKey")]
        [Validation(Required=false)]
        public string NetworkAccessFileKey { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("UnifiedCode")]
        [Validation(Required=false)]
        public string UnifiedCode { get; set; }

    }

}
