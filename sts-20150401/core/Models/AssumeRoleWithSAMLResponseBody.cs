// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithSAMLResponseBody : TeaModel {
        /// <summary>
        /// The temporary identity that you use to assume the RAM role.
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithSAMLResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// The ARN of the temporary identity that you use to assume the RAM role.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the temporary identity that you use to assume the RAM role.
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        /// <summary>
        /// The STS credentials.
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithSAMLResponseBodyCredentials : TeaModel {
            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The time when the STS token expires. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// The STS token.
            /// 
            /// > Alibaba Cloud STS does not impose limits on the length of STS tokens. We strongly recommend that you do not specify a maximum length for STS tokens.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information in the SAML assertion.
        /// </summary>
        [NameInMap("SAMLAssertionInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodySAMLAssertionInfo SAMLAssertionInfo { get; set; }
        public class AssumeRoleWithSAMLResponseBodySAMLAssertionInfo : TeaModel {
            /// <summary>
            /// The value in the `Issuer` element in the SAML assertion.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// The `Recipient` attribute of the SubjectConfirmationData sub-element. SubjectConfirmationData is a sub-element of the `Subject` element in the SAML assertion.
            /// </summary>
            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public string Recipient { get; set; }

            /// <summary>
            /// The value in the NameID sub-element of the `Subject` element in the SAML assertion.
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// The Format attribute of the `NameID` element in the SAML assertion. If the Format attribute is prefixed with `urn:oasis:names:tc:SAML:2.0:nameid-format:`, the prefix is not included in the value of this parameter. For example, if the value of the Format attribute is urn:oasis:names:tc:SAML:2.0:nameid-format:persistent/transient, the value of this parameter is `persistent/transient`.
            /// </summary>
            [NameInMap("SubjectType")]
            [Validation(Required=false)]
            public string SubjectType { get; set; }

        }

    }

}
