// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSAMLIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("JITProvisionStatus")]
        [Validation(Required=false)]
        public string JITProvisionStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("JITUpdateStatus")]
        [Validation(Required=false)]
        public string JITUpdateStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/sso/saml">https://idp.example.com/sso/saml</a></para>
        /// </summary>
        [NameInMap("LoginURL")]
        [Validation(Required=false)]
        public string LoginURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP-Redirect</para>
        /// </summary>
        [NameInMap("SAMLBindingType")]
        [Validation(Required=false)]
        public string SAMLBindingType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

        [NameInMap("X509Certificates")]
        [Validation(Required=false)]
        public List<string> X509Certificates { get; set; }

    }

}
