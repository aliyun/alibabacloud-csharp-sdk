// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary identity that you use to assume the RAM role.</para>
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithOIDCResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// <para>The ARN of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::113511544585****:role/testoidc/TestOidcAssumedRoleSession</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33157794895460****</para>
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        /// <summary>
        /// <para>The access credentials.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithOIDCResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NUgYrLnoC37mZZCNnAbez****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVwjCkNzTMupZ8NbTCxCBRq3K16jtcWFTJAyBEv2****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The time when the STS token expires. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-20T04:27:09Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The STS token.</para>
            /// <remarks>
            /// <para>Alibaba Cloud STS does not impose limits on the length of STS tokens. We strongly recommend that you do not specify a maximum length for STS tokens.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CAIShwJ1q6Ft5B2yfSjIr5bSEsj4g7BihPWGWHz****</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The information about the OIDC token.</para>
        /// </summary>
        [NameInMap("OIDCTokenInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyOIDCTokenInfo OIDCTokenInfo { get; set; }
        public class AssumeRoleWithOIDCResponseBodyOIDCTokenInfo : TeaModel {
            /// <summary>
            /// <para>The audience. If multiple audiences are returned, the audiences are separated by commas (,).</para>
            /// <para>The audience is represented by the <c>aud</c> field in the OIDC Token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>496271242565057****</para>
            /// </summary>
            [NameInMap("ClientIds")]
            [Validation(Required=false)]
            public string ClientIds { get; set; }

            /// <summary>
            /// <para>The time when the OIDC token expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-20T04:27:09Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The time when the OIDC token was issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-20T03:27:09Z</para>
            /// </summary>
            [NameInMap("IssuanceTime")]
            [Validation(Required=false)]
            public string IssuanceTime { get; set; }

            /// <summary>
            /// <para>The URL of the issuer,</para>
            /// <para>which is represented by the <c>iss</c> field in the OIDC Token.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dev-xxxxxx.okta.com">https://dev-xxxxxx.okta.com</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The subject,</para>
            /// <para>which is represented by the <c>sub</c> field in the OIDC Token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KryrkIdjylZb7agUgCEf****</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The verification information about the OIDC token. For more information, see <a href="https://help.aliyun.com/document_detail/327123.html">Manage an OIDC IdP</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("VerificationInfo")]
            [Validation(Required=false)]
            public string VerificationInfo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D57EAD2-8723-1F26-B69C-F8707D8B565D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceIdentity")]
        [Validation(Required=false)]
        public string SourceIdentity { get; set; }

    }

}
