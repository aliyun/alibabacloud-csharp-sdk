// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSAMLIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The IdP identifier. This is the EntityID from the SAML metadata of the external IdP.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The enabling status of Just-In-Time (JIT) user synchronization and creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Enabled. If a user with the same name does not exist in the user pool during SAML logon, automatic creation is performed.</description></item>
        /// <item><description>Disabled: Shutdown. If the user is not found, the logon is failed. Default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("JITProvisionStatus")]
        [Validation(Required=false)]
        public string JITProvisionStatus { get; set; }

        /// <summary>
        /// <para>The enabling status of updating user information through synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The update is enabled. If a user with the same name exists during SAML logon, the user information is updated based on the attributes (DisplayName and Description) passed by the IdP.</description></item>
        /// <item><description>Disabled: The update is disabled. Only the logon state is updated, and user attributes are not updated. Default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("JITUpdateStatus")]
        [Validation(Required=false)]
        public string JITUpdateStatus { get; set; }

        /// <summary>
        /// <para>The IdP logon URL. When a user logs on, the browser is redirected to this URL to complete SAML authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/sso/saml">https://idp.example.com/sso/saml</a></para>
        /// </summary>
        [NameInMap("LoginURL")]
        [Validation(Required=false)]
        public string LoginURL { get; set; }

        /// <summary>
        /// <para>The SAML protocol binding type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP-Redirect: AuthnRequest is sent by using HTTP redirect. Default value.</description></item>
        /// <item><description>HTTP-POST: AuthnRequest is sent by using HTTP POST.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP-Redirect</para>
        /// </summary>
        [NameInMap("SAMLBindingType")]
        [Validation(Required=false)]
        public string SAMLBindingType { get; set; }

        /// <summary>
        /// <para>The enabling status of single sign-on (SSO). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: SAML SSO is enabled, and users can log on through an external IdP.</description></item>
        /// <item><description>Disabled: SAML SSO is disabled, and users cannot log on through the IdP. Default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

        /// <summary>
        /// <para>The list of X.509 certificates in PEM format. If you specify this parameter, all existing certificates are replaced.</para>
        /// </summary>
        [NameInMap("X509Certificates")]
        [Validation(Required=false)]
        public List<string> X509Certificates { get; set; }

    }

}
