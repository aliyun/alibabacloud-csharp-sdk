// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSAMLIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed configurations of the identity provider.</para>
        /// </summary>
        [NameInMap("SSOIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfiguration SSOIdentityProviderConfiguration { get; set; }
        public class SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfiguration : TeaModel {
            /// <summary>
            /// <para>The IdP identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The enabling status of Just-In-Time (JIT) user provisioning. A value of Enabled indicates that JIT user provisioning is enabled, and a value of Disabled indicates that it is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("JITProvisionStatus")]
            [Validation(Required=false)]
            public string JITProvisionStatus { get; set; }

            /// <summary>
            /// <para>The enabling status of updating user information through synchronization. A value of Enabled indicates that the update is enabled, and a value of Disabled indicates that it is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("JITUpdateStatus")]
            [Validation(Required=false)]
            public string JITUpdateStatus { get; set; }

            /// <summary>
            /// <para>The IdP logon URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idp.example.com/sso/saml">https://idp.example.com/sso/saml</a></para>
            /// </summary>
            [NameInMap("LoginURL")]
            [Validation(Required=false)]
            public string LoginURL { get; set; }

            /// <summary>
            /// <para>The SAML protocol binding type. Valid values: HTTP-Redirect and HTTP-POST.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP-Redirect</para>
            /// </summary>
            [NameInMap("SAMLBindingType")]
            [Validation(Required=false)]
            public string SAMLBindingType { get; set; }

            /// <summary>
            /// <para>The enabling status of single sign-on (SSO). A value of Enabled indicates that SSO is enabled, and a value of Disabled indicates that SSO is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

            /// <summary>
            /// <para>The list of X.509 certificates.</para>
            /// </summary>
            [NameInMap("X509Certificates")]
            [Validation(Required=false)]
            public List<SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfigurationX509Certificates> X509Certificates { get; set; }
            public class SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfigurationX509Certificates : TeaModel {
                /// <summary>
                /// <para>The certificate ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert-xxxxxxxxxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                /// <summary>
                /// <para>The content of the X.509 certificate in PEM format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----
                /// MIIDdz...
                /// -----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("X509Certificate")]
                [Validation(Required=false)]
                public string X509Certificate { get; set; }

            }

        }

    }

}
