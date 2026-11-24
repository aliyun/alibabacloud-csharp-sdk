// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetIdpConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The identity source configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIdpConfigResponseBodyData Data { get; set; }
        public class GetIdpConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the IDaaS identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleAccessKeyId****</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the IDaaS identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleAccessKeySecret****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The description of the identity source configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample identity source</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The URL used to query the organizational structure of a self-managed identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://172.10.XX.XX:4321/getGroup?name=%s&pass=%s">https://172.10.XX.XX:4321/getGroup?name=%s&amp;pass=%s</a></para>
            /// </summary>
            [NameInMap("GetGroupUrl")]
            [Validation(Required=false)]
            public string GetGroupUrl { get; set; }

            /// <summary>
            /// <para>The ID of the identity source configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-cfg68956d86e********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The metadata of the identity provider (IdP).</para>
            /// 
            /// <b>Example:</b>
            /// <?xml version="1.0" encoding="utf-8"?><hr>
            /// </summary>
            [NameInMap("IdpMetadata")]
            [Validation(Required=false)]
            public string IdpMetadata { get; set; }

            /// <summary>
            /// <para>The configuration type of secondary authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MfaConfigType")]
            [Validation(Required=false)]
            public string MfaConfigType { get; set; }

            /// <summary>
            /// <para>The logon type for mobile devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("MobileLoginType")]
            [Validation(Required=false)]
            public string MobileLoginType { get; set; }

            /// <summary>
            /// <para>The configuration type of secondary authentication for mobile devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MobileMfaConfigType")]
            [Validation(Required=false)]
            public string MobileMfaConfigType { get; set; }

            /// <summary>
            /// <para>The IDs of multiple identity source configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1482,1355</para>
            /// </summary>
            [NameInMap("MultiIdpInfo")]
            [Validation(Required=false)]
            public string MultiIdpInfo { get; set; }

            /// <summary>
            /// <para>The name of the identity source configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample identity source</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The logon type for PCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("PcLoginType")]
            [Validation(Required=false)]
            public string PcLoginType { get; set; }

            /// <summary>
            /// <para>The enabling status of the identity source configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the identity source configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSAS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-26T02:02:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The encryption key used for requests to a self-managed secondary authentication service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QVhaU0RDR0JIWV****</para>
            /// </summary>
            [NameInMap("VerifyAesKey")]
            [Validation(Required=false)]
            public string VerifyAesKey { get; set; }

            /// <summary>
            /// <para>The token used to verify the request signature of a self-managed secondary authentication service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7JAr3fYtn****</para>
            /// </summary>
            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }

            /// <summary>
            /// <para>The verification URL of a self-managed secondary authentication service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://172.10.XX.XX:1234/otp_verify">http://172.10.XX.XX:1234/otp_verify</a></para>
            /// </summary>
            [NameInMap("VerifyUrl")]
            [Validation(Required=false)]
            public string VerifyUrl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
