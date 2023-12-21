/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CertNoTwoElementVerificationRequest : TeaModel {
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
