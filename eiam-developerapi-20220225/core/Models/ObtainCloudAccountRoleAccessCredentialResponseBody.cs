// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCloudAccountRoleAccessCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("cloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The temporary access credentials for assuming the cloud account role.</para>
        /// </summary>
        [NameInMap("cloudAccountRoleAccessCredential")]
        [Validation(Required=false)]
        public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredential CloudAccountRoleAccessCredential { get; set; }
        public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredential : TeaModel {
            /// <summary>
            /// <para>The expiration time of the temporary access credentials for the cloud account role, in UNIX timestamp format and in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767196800</para>
            /// </summary>
            [NameInMap("accessCredentialExpiresAt")]
            [Validation(Required=false)]
            public long? AccessCredentialExpiresAt { get; set; }

            /// <summary>
            /// <para>The temporary identity credentials (STS Token) for assuming an Alibaba Cloud RAM role.</para>
            /// <remarks>
            /// <para>This field is returned only when the cloud account type associated with the cloud account role is Alibaba Cloud (alibaba_cloud).</para>
            /// </remarks>
            /// </summary>
            [NameInMap("alibabaCloudStsToken")]
            [Validation(Required=false)]
            public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAlibabaCloudStsToken AlibabaCloudStsToken { get; set; }
            public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAlibabaCloudStsToken : TeaModel {
                /// <summary>
                /// <para>The access key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STS.NUgYrLnoC37mZZCNnAbez****</para>
                /// </summary>
                [NameInMap("accessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <para>The access key secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CVwjCkNzTMupZ8NbTCxCBRq3K16jtcWFTJAyBEv2****</para>
                /// </summary>
                [NameInMap("accessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                /// <summary>
                /// <para>The expiration time of the token (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-20T04:27:09Z</para>
                /// </summary>
                [NameInMap("expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                /// <summary>
                /// <para>The security token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CAIShwJ1q6Ft5B2yfSjIr5bSEsj4g7BihPWGWHz****</para>
                /// </summary>
                [NameInMap("securityToken")]
                [Validation(Required=false)]
                public string SecurityToken { get; set; }

            }

            /// <summary>
            /// <para>The STS Token representing an AWS role.</para>
            /// </summary>
            [NameInMap("awsStsToken")]
            [Validation(Required=false)]
            public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAwsStsToken AwsStsToken { get; set; }
            public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAwsStsToken : TeaModel {
                /// <summary>
                /// <para>The access key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ASIAYBGN7XJKRFOM****</para>
                /// </summary>
                [NameInMap("accessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <para>The expiration time of the STS Token (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-20T04:27:09Z</para>
                /// </summary>
                [NameInMap("expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                /// <summary>
                /// <para>The secret access key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CVwjCkNzTMupZ8NbTCxCBRq3K16jtcWFTJAyBEv2****</para>
                /// </summary>
                [NameInMap("secretAccessKey")]
                [Validation(Required=false)]
                public string SecretAccessKey { get; set; }

                /// <summary>
                /// <para>The session token of the temporary credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FwoDYXdzEJzfSjIr5bSEsj4g7BihPWGWHz****</para>
                /// </summary>
                [NameInMap("sessionToken")]
                [Validation(Required=false)]
                public string SessionToken { get; set; }

            }

            [NameInMap("tencentCloudStsToken")]
            [Validation(Required=false)]
            public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialTencentCloudStsToken TencentCloudStsToken { get; set; }
            public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialTencentCloudStsToken : TeaModel {
                [NameInMap("expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                [NameInMap("tmpSecretId")]
                [Validation(Required=false)]
                public string TmpSecretId { get; set; }

                [NameInMap("tmpSecretKey")]
                [Validation(Required=false)]
                public string TmpSecretKey { get; set; }

                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

        }

        /// <summary>
        /// <para>The business identifier of the cloud account role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::xxx:role/role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleExternalId")]
        [Validation(Required=false)]
        public string CloudAccountRoleExternalId { get; set; }

        /// <summary>
        /// <para>The cloud account role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>carole_01kmek49aqxxxx</para>
        /// </summary>
        [NameInMap("cloudAccountRoleId")]
        [Validation(Required=false)]
        public string CloudAccountRoleId { get; set; }

        /// <summary>
        /// <para>The cloud account role name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleName")]
        [Validation(Required=false)]
        public string CloudAccountRoleName { get; set; }

        /// <summary>
        /// <para>The cloud account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>alibaba_cloud: Alibaba Cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("cloudAccountVendorType")]
        [Validation(Required=false)]
        public string CloudAccountVendorType { get; set; }

    }

}
