// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud account details.</para>
        /// </summary>
        [NameInMap("CloudAccount")]
        [Validation(Required=false)]
        public GetCloudAccountResponseBodyCloudAccount CloudAccount { get; set; }
        public class GetCloudAccountResponseBodyCloudAccount : TeaModel {
            /// <summary>
            /// <para>The external unique identifier of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CloudAccountExternalId")]
            [Validation(Required=false)]
            public string CloudAccountExternalId { get; set; }

            /// <summary>
            /// <para>The health status of the cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>healthy: Healthy.</description></item>
            /// <item><description>unhealthy: Unhealthy.</description></item>
            /// <item><description>unknown: Unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountHealth")]
            [Validation(Required=false)]
            public string CloudAccountHealth { get; set; }

            /// <summary>
            /// <para>The health check result of the cloud account.</para>
            /// </summary>
            [NameInMap("CloudAccountHealthCheckResult")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult CloudAccountHealthCheckResult { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The error reason. This field is returned when the health check status is unhealthy.</para>
                /// </summary>
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResultErrorReason ErrorReason { get; set; }
                public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResultErrorReason : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AuthenticationFail.NoPermission</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The time of the last health check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The health check result of the cloud account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: Succeeded.</description></item>
                /// <item><description>failed: Failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The cloud account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountName")]
            [Validation(Required=false)]
            public string CloudAccountName { get; set; }

            /// <summary>
            /// <para>The identity provider configuration.</para>
            /// </summary>
            [NameInMap("CloudAccountProviderConfig")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig CloudAccountProviderConfig { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig : TeaModel {
                /// <summary>
                /// <para>The audience identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:cloud:idaas:sts:xxx:xxx</para>
                /// </summary>
                [NameInMap("Audience")]
                [Validation(Required=false)]
                public string Audience { get; set; }

                /// <summary>
                /// <para>The authorization server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iauths_system</para>
                /// </summary>
                [NameInMap("AuthorizationServerId")]
                [Validation(Required=false)]
                public string AuthorizationServerId { get; set; }

                /// <summary>
                /// <para>Issuer。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2">https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The signature verification public key endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks">https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The identity provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-eiam-oidc-provider</para>
            /// </summary>
            [NameInMap("CloudAccountProviderName")]
            [Validation(Required=false)]
            public string CloudAccountProviderName { get; set; }

            [NameInMap("CloudAccountSite")]
            [Validation(Required=false)]
            public string CloudAccountSite { get; set; }

            /// <summary>
            /// <para>The cloud account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>alibaba_cloud: Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("CloudAccountVendorType")]
            [Validation(Required=false)]
            public string CloudAccountVendorType { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The cloud account description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
