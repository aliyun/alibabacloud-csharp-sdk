// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetExternalSAMLIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96D1E5FF-0301-5636-8D33-071E033CFB82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the IdP.</para>
        /// </summary>
        [NameInMap("SAMLIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public GetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration SAMLIdentityProviderConfiguration { get; set; }
        public class GetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration : TeaModel {
            /// <summary>
            /// <para>The binding for sending SAML requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Post: HTTP Post bindings.</description></item>
            /// <item><description>Redirect: HTTP Redirect bindings.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Post</para>
            /// </summary>
            [NameInMap("BindingType")]
            [Validation(Required=false)]
            public string BindingType { get; set; }

            /// <summary>
            /// <para>The SAML signing certificates.</para>
            /// </summary>
            [NameInMap("CertificateIds")]
            [Validation(Required=false)]
            public List<string> CertificateIds { get; set; }

            /// <summary>
            /// <para>The time when the IdP was configured for the first time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09T09:30:13Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The metadata file of the IdP. The value of this parameter is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD94bWwgdmVyc2lvbj0iMS4****</para>
            /// </summary>
            [NameInMap("EncodedMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedMetadataDocument { get; set; }

            /// <summary>
            /// <para>The ID of the IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.okta.com/exk3qwgtjhetR2Od">http://www.okta.com/exk3qwgtjhetR2Od</a>****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The logon URL of the IdP.</para>
            /// </summary>
            [NameInMap("LoginUrl")]
            [Validation(Required=false)]
            public string LoginUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether SSO is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

            /// <summary>
            /// <para>The time when the IdP configurations were last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09T09:30:22Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether CloudSSO needs to sign SAML requests. The requests are sent when users log on to the CloudSSO user portal to initiate SAML-based SSO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true:</description></item>
            /// <item><description>false (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WantRequestSigned")]
            [Validation(Required=false)]
            public bool? WantRequestSigned { get; set; }

        }

    }

}
