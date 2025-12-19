// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class AssumeRoleForWorkloadIdentityResponseBody : TeaModel {
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::113511544585****:role/testoidc/TestOidcAssumedRoleSession</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33157794895460****</para>
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>STS.NTTcrF2UNgeshFRTj9i7hpkah</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3fNFJk4UA6KLEG2GXiBe9ZE43ejFRJsea1yT1rguTVY6</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-28T03:06:19Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAIShwJ1q6Ft5B2yfSjIr5bSEsj4g7BihPWGWHz****</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B7F68680-F3FE-5BF1-A824-4DE0B1AC9B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadContextInfo")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfo WorkloadContextInfo { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfo : TeaModel {
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContext UserContext { get; set; }
            public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContext : TeaModel {
                [NameInMap("JwtClaims")]
                [Validation(Required=false)]
                public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContextJwtClaims JwtClaims { get; set; }
                public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContextJwtClaims : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;test-aud&quot;,&quot;test-aud-2&quot;]</para>
                    /// </summary>
                    [NameInMap("Audiences")]
                    [Validation(Required=false)]
                    public string Audiences { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://oauth.aliyun.com">https://oauth.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>externalUser</para>
                    /// </summary>
                    [NameInMap("Subject")]
                    [Validation(Required=false)]
                    public string Subject { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>externalUser</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:1778**<em><b>8462:workloadidentitydirectory/default/workloadidentity/workload-bc7</b></em></para>
            /// </summary>
            [NameInMap("WorkloadIdentityArn")]
            [Validation(Required=false)]
            public string WorkloadIdentityArn { get; set; }

        }

    }

}
