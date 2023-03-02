// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCResponseBody : TeaModel {
        /// <summary>
        /// The temporary identity that you use to assume the RAM role.
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithOIDCResponseBodyAssumedRoleUser : TeaModel {
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
        /// The access credentials.
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithOIDCResponseBodyCredentials : TeaModel {
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
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// The information about the OIDC token.
        /// </summary>
        [NameInMap("OIDCTokenInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyOIDCTokenInfo OIDCTokenInfo { get; set; }
        public class AssumeRoleWithOIDCResponseBodyOIDCTokenInfo : TeaModel {
            /// <summary>
            /// The audience. If multiple audiences are returned, the audiences are separated by commas (,).
            /// 
            /// The audience is represented by the `aud` field in the OIDC Token.
            /// </summary>
            [NameInMap("ClientIds")]
            [Validation(Required=false)]
            public string ClientIds { get; set; }

            /// <summary>
            /// The URL of the issuer,
            /// 
            /// which is represented by the `iss` field in the OIDC Token.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// The subject,
            /// 
            /// which is represented by the `sub` field in the OIDC Token.
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
