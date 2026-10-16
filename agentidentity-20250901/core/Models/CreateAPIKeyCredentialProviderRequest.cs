// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateAPIKeyCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The API key value to be securely stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example api key</para>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The name of the credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-key-dash-scope</para>
        /// </summary>
        [NameInMap("APIKeyCredentialProviderName")]
        [Validation(Required=false)]
        public string APIKeyCredentialProviderName { get; set; }

        /// <summary>
        /// <para>The description of the credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The TokenVault name.</para>
        /// </summary>
        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
