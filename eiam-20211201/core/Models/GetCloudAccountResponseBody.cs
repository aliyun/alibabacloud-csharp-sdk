// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudAccountResponseBody : TeaModel {
        [NameInMap("CloudAccount")]
        [Validation(Required=false)]
        public GetCloudAccountResponseBodyCloudAccount CloudAccount { get; set; }
        public class GetCloudAccountResponseBodyCloudAccount : TeaModel {
            /// <summary>
            /// <para>云账号外部唯一ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CloudAccountExternalId")]
            [Validation(Required=false)]
            public string CloudAccountExternalId { get; set; }

            /// <summary>
            /// <para>云账号状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountHealth")]
            [Validation(Required=false)]
            public string CloudAccountHealth { get; set; }

            [NameInMap("CloudAccountHealthCheckResult")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult CloudAccountHealthCheckResult { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResult : TeaModel {
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResultErrorReason ErrorReason { get; set; }
                public class GetCloudAccountResponseBodyCloudAccountCloudAccountHealthCheckResultErrorReason : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AuthenticationFail.NoPermission</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>云账号ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>云账号名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountName")]
            [Validation(Required=false)]
            public string CloudAccountName { get; set; }

            /// <summary>
            /// <para>云账号提供商配置</para>
            /// </summary>
            [NameInMap("CloudAccountProviderConfig")]
            [Validation(Required=false)]
            public GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig CloudAccountProviderConfig { get; set; }
            public class GetCloudAccountResponseBodyCloudAccountCloudAccountProviderConfig : TeaModel {
                /// <summary>
                /// <para>受众标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:cloud:idaas:sts:xxx:xxx</para>
                /// </summary>
                [NameInMap("Audience")]
                [Validation(Required=false)]
                public string Audience { get; set; }

                /// <summary>
                /// <para>授权服务ID</para>
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
                /// <para>验签公钥端点</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks">https://xxxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

            }

            /// <summary>
            /// <para>云账号提供商名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-eiam-oidc-provider</para>
            /// </summary>
            [NameInMap("CloudAccountProviderName")]
            [Validation(Required=false)]
            public string CloudAccountProviderName { get; set; }

            /// <summary>
            /// <para>云账号类别</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("CloudAccountVendorType")]
            [Validation(Required=false)]
            public string CloudAccountVendorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>云账号描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
