// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateSAMLProviderRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a provider.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata file which is Base64-encoded.</para>
        /// <para>The file is provided by an IdP that supports Security Assertion Markup Language (SAML) 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PD94bWwgdmVy****</para>
        /// </summary>
        [NameInMap("EncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string EncodedSAMLMetadataDocument { get; set; }

        /// <summary>
        /// <para>The name of the IdP.</para>
        /// <para>The name can be up to 128 characters in length. The name can contain letters, digits, <c>periods (.), hyphens (-), and underscores (_)</c>. The name cannot start or end with <c>periods (.), hyphens (-), or underscores (_)</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-provider</para>
        /// </summary>
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

    }

}
