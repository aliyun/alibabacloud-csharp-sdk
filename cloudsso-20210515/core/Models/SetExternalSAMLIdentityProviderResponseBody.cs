// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetExternalSAMLIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63160579-2E1B-57B0-8273-B27427172385</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the IdP.</para>
        /// </summary>
        [NameInMap("SAMLIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public SetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration SAMLIdentityProviderConfiguration { get; set; }
        public class SetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration : TeaModel {
            /// <summary>
            /// <para>The Binding method for initiating a SAML request. Values:</para>
            /// <list type="bullet">
            /// <item><description>Post: Initiate the SAML request using the Post method. </description></item>
            /// <item><description>Redirect: Initiate the SAML request using the Redirect method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Redirect</para>
            /// </summary>
            [NameInMap("BindingType")]
            [Validation(Required=false)]
            public string BindingType { get; set; }

            /// <summary>
            /// <para>The ID of the SAML signing certificate.</para>
            /// </summary>
            [NameInMap("CertificateIds")]
            [Validation(Required=false)]
            public List<string> CertificateIds { get; set; }

            /// <summary>
            /// <para>The time when the IdP was configured for the first time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-10T02:57:16Z</para>
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
            /// <para>The entity ID of the IdP.</para>
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
            /// <para>The status of SSO logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

            /// <summary>
            /// <para>The time when the IdP configurations were last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-10T02:57:16Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether CloudSSO needs to sign SAML requests. The requests are sent when users log on to the CloudSSO user portal to initiate SAML-based SSO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes</description></item>
            /// <item><description>false: no (default)</description></item>
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
