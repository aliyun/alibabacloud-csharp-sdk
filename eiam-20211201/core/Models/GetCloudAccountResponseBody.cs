// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("CloudAccount")]
        [Validation(Required=false)]
        public GetCloudAccountResponseBodyCloudAccount CloudAccount { get; set; }
        public class GetCloudAccountResponseBodyCloudAccount : TeaModel {
            /// <summary>
            /// <para>The unique external ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CloudAccountExternalId")]
            [Validation(Required=false)]
            public string CloudAccountExternalId { get; set; }

            /// <summary>
            /// <para>The health status of the Alibaba Cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>healthy: Healthy.</para>
            /// </description></item>
            /// <item><description><para>unhealthy: Unhealthy.</para>
            /// </description></item>
            /// <item><description><para>unknown: Unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountHealth")]
            [Validation(Required=false)]
            public string CloudAccountHealth { get; set; }

            /// <summary>
            /// <para>The health check result for the cloud account.</para>
            /// </summary>
            [NameInMap("CloudAccountHealthCheckResult")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult CloudAccountHealthCheckResult { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The reason for the fault. This field returns a value when the health check status is unhealthy.</para>
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
                    /// <para>The description of the error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The time of the last check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The result of the health check for the cloud account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>success: The health check was successful.</para>
                /// </description></item>
                /// <item><description><para>failed: The health check failed.</para>
                /// </description></item>
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
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountName")]
            [Validation(Required=false)]
            public string CloudAccountName { get; set; }

            /// <summary>
            /// <para>The configuration of the identity provider.</para>
            /// </summary>
            [NameInMap("CloudAccountProviderConfig")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig CloudAccountProviderConfig { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig : TeaModel {
                /// <summary>
                /// <para>The audience identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:cloud:idaas:sts:xxx:xxx</para>
                /// </summary>
                [NameInMap("Audience")]
                [Validation(Required=false)]
                public string Audience { get; set; }

                /// <summary>
                /// <para>The ID of the authorization server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iauths_system</para>
                /// </summary>
                [NameInMap("AuthorizationServerId")]
                [Validation(Required=false)]
                public string AuthorizationServerId { get; set; }

                /// <summary>
                /// <para>The issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2">https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The public key endpoint for signature verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks">https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The name of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-eiam-oidc-provider</para>
            /// </summary>
            [NameInMap("CloudAccountProviderName")]
            [Validation(Required=false)]
            public string CloudAccountProviderName { get; set; }

            /// <summary>
            /// <para>The type of the Alibaba Cloud account. The valid value is:</para>
            /// <list type="bullet">
            /// <item><description>alibaba_cloud: Alibaba Cloud</description></item>
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
            /// <para>The description of the Alibaba Cloud account.</para>
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
            /// <para>The time of the last update. The value is a UNIX timestamp in milliseconds.</para>
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
