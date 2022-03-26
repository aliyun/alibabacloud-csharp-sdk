// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithSAMLResponseBody : TeaModel {
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithSAMLResponseBodyAssumedRoleUser : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }
        };

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithSAMLResponseBodyCredentials : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SAMLAssertionInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodySAMLAssertionInfo SAMLAssertionInfo { get; set; }
        public class AssumeRoleWithSAMLResponseBodySAMLAssertionInfo : TeaModel {
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }
            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public string Recipient { get; set; }
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }
            [NameInMap("SubjectType")]
            [Validation(Required=false)]
            public string SubjectType { get; set; }
        };

    }

}
