// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BaasDis20200509.Models
{
    public class IssueNormalVerifiableVCRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BareClaimStructBody")]
        [Validation(Required=false)]
        public List<IssueNormalVerifiableVCRequestBareClaimStructBody> BareClaimStructBody { get; set; }
        public class IssueNormalVerifiableVCRequestBareClaimStructBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Claim")]
            [Validation(Required=false)]
            public string Claim { get; set; }

            [NameInMap("ClaimType")]
            [Validation(Required=false)]
            public string ClaimType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
