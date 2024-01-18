// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
