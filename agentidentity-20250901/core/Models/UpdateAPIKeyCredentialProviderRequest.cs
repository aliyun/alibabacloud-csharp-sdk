// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateAPIKeyCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The new API key value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new example api key</para>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The name of the credential provider to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-key-dash-scope</para>
        /// </summary>
        [NameInMap("APIKeyCredentialProviderName")]
        [Validation(Required=false)]
        public string APIKeyCredentialProviderName { get; set; }

        /// <summary>
        /// <para>The new description of the credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new example provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the token vault. Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
