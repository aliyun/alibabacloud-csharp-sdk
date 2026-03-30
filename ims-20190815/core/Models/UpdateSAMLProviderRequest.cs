// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateSAMLProviderRequest : TeaModel {
        [NameInMap("AuthnSignAlgo")]
        [Validation(Required=false)]
        public string AuthnSignAlgo { get; set; }

        /// <summary>
        /// <para>The new description.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <c>NewDescription</c> and <c>NewEncodedSAMLMetadataDocument</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new provider.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new metadata file.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <c>NewDescription</c> and <c>NewEncodedSAMLMetadataDocument</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PD94bWwgdmVy****</para>
        /// </summary>
        [NameInMap("NewEncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string NewEncodedSAMLMetadataDocument { get; set; }

        /// <summary>
        /// <para>The name of the IdP whose information you want to modify.</para>
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
