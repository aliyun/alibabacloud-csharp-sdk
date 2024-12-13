// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetExternalSAMLIdentityProviderRequest : TeaModel {
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
        /// <para>The file is provided by the IdP that supports SAML 2.0.</para>
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
        /// <item><description>Disabled (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether CloudSSO needs to sign SAML requests. The requests are sent when users log on to the CloudSSO user portal to initiate SAML-based SSO. Valid values:</para>
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

        /// <summary>
        /// <para>The X.509 certificate in the PEM format. If you specify this parameter, all existing certificates are replaced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIC8DCCAdigAwIBAgIQP9eomUYGeoND****</para>
        /// </summary>
        [NameInMap("X509Certificate")]
        [Validation(Required=false)]
        public string X509Certificate { get; set; }

    }

}
