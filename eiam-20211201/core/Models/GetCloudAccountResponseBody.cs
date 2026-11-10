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
            /// <para>The cloud account health status. Valid values:</para>
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
            /// <para>The cloud account health check result.</para>
            /// </summary>
            [NameInMap("CloudAccountHealthCheckResult")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult CloudAccountHealthCheckResult { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The error reason. This field returns a value when the health check status is unhealthy.</para>
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
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The last check time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The cloud account health check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: Success.</description></item>
                /// <item><description>failed: Failure.</description></item>
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
            /// <para>The identity provider configuration information.</para>
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
            /// <para>The identity provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-eiam-oidc-provider</para>
            /// </summary>
            [NameInMap("CloudAccountProviderName")]
            [Validation(Required=false)]
            public string CloudAccountProviderName { get; set; }

            /// <summary>
            /// <para>The cloud account site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>china_mainland: The Chinese mainland.</description></item>
            /// <item><description>global: Global.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>china_mainland</para>
            /// </summary>
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
            /// <para>The list of associated privilege application IDs.</para>
            /// </summary>
            [NameInMap("PrivilegeApplicationIds")]
            [Validation(Required=false)]
            public List<string> PrivilegeApplicationIds { get; set; }

            /// <summary>
            /// <para>The cause of the privilege hosting or removal failure.</para>
            /// </summary>
            [NameInMap("PrivilegeHostingError")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountPrivilegeHostingError PrivilegeHostingError { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountPrivilegeHostingError : TeaModel {
                /// <summary>
                /// <para>The failure error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The failure message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test message</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The cloud account hosting status. Default value: hosting_unmanaged. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hosting_unmanaged: Unmanaged. The cloud account has not initiated hosting and is in the initial state.</description></item>
            /// <item><description>hosting_pending: Hosting. The hosting task is submitted and executed asynchronously. You must wait for the hosting process to complete to enter the final state.</description></item>
            /// <item><description>hosting_completed: Hosting completed. The hosting process is executed successfully, and the relevant permission templates and hosting bindings take effect.</description></item>
            /// <item><description>hosting_failed: Hosting failed. An exception occurs during the hosting process. You can view the failure cause and initiate hosting again.</description></item>
            /// <item><description>hosting_removing: Removing. The removal task is submitted and executed asynchronously. You must wait for the removal process to complete to enter the final state.</description></item>
            /// <item><description>hosting_remove_failed: Removal failed. An exception occurs during the removal process. You can view the failure cause and initiate removal again.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hosting_unmanaged</para>
            /// </summary>
            [NameInMap("PrivilegeHostingState")]
            [Validation(Required=false)]
            public string PrivilegeHostingState { get; set; }

            /// <summary>
            /// <para>The privilege switch status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled. The resource is active and can be used normally.</description></item>
            /// <item><description>disabled: Disabled. The resource is deactivated and no longer takes effect. You can re-enable it to restore the resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PrivilegeStatus")]
            [Validation(Required=false)]
            public string PrivilegeStatus { get; set; }

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
