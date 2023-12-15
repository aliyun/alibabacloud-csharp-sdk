// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BaasDis20200509.Models
{
    public class IssueNormalVerifiableVCRequest : TeaModel {
        [NameInMap("BareClaimStructBody")]
        [Validation(Required=false)]
        public List<IssueNormalVerifiableVCRequestBareClaimStructBody> BareClaimStructBody { get; set; }
        public class IssueNormalVerifiableVCRequestBareClaimStructBody : TeaModel {
            [NameInMap("Claim")]
            [Validation(Required=false)]
            public string Claim { get; set; }

            [NameInMap("ClaimType")]
            [Validation(Required=false)]
            public string ClaimType { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
