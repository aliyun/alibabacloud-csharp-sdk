// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetIdpConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Identity provider configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIdpConfigResponseBodyData Data { get; set; }
        public class GetIdpConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>AccessKey ID for the IDaaS identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>AccessKey for the IDaaS identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>Description of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例身份源</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>URL to query the organizational structure from a custom identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://172.10.XX.XX:4321/getGroup?name=%s&pass=%s">https://172.10.XX.XX:4321/getGroup?name=%s&amp;pass=%s</a></para>
            /// </summary>
            [NameInMap("GetGroupUrl")]
            [Validation(Required=false)]
            public string GetGroupUrl { get; set; }

            /// <summary>
            /// <para>ID of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-cfg68956d86e********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Metadata of the identity provider (IdP).</para>
            /// 
            /// <b>Example:</b>
            /// <?xml version="1.0" encoding="utf-8"?><hr>
            /// </summary>
            [NameInMap("IdpMetadata")]
            [Validation(Required=false)]
            public string IdpMetadata { get; set; }

            /// <summary>
            /// <para>Type of multi-factor authentication (MFA) configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MfaConfigType")]
            [Validation(Required=false)]
            public string MfaConfigType { get; set; }

            /// <summary>
            /// <para>Login type for mobile clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("MobileLoginType")]
            [Validation(Required=false)]
            public string MobileLoginType { get; set; }

            /// <summary>
            /// <para>Type of MFA configuration for mobile clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MobileMfaConfigType")]
            [Validation(Required=false)]
            public string MobileMfaConfigType { get; set; }

            /// <summary>
            /// <para>List of IDs for multiple identity providers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1482,1355</para>
            /// </summary>
            [NameInMap("MultiIdpInfo")]
            [Validation(Required=false)]
            public string MultiIdpInfo { get; set; }

            /// <summary>
            /// <para>Name of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例身份源</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Login type for PC clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("PcLoginType")]
            [Validation(Required=false)]
            public string PcLoginType { get; set; }

            /// <summary>
            /// <para>Status of the identity provider configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Type of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSAS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Time when the configuration was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-26T02:02:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>AES key used to encrypt requests to a custom MFA service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QVhaU0RDR0JIWV****</para>
            /// </summary>
            [NameInMap("VerifyAesKey")]
            [Validation(Required=false)]
            public string VerifyAesKey { get; set; }

            /// <summary>
            /// <para>Token used to verify signatures in requests to a custom MFA service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7JAr3fYtn****</para>
            /// </summary>
            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }

            /// <summary>
            /// <para>URL used to verify one-time passwords with a custom MFA service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://172.10.XX.XX:1234/otp_verify">http://172.10.XX.XX:1234/otp_verify</a></para>
            /// </summary>
            [NameInMap("VerifyUrl")]
            [Validation(Required=false)]
            public string VerifyUrl { get; set; }

        }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
