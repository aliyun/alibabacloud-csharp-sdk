// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class DeleteAPIKeyCredentialProviderRequest : TeaModel {
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
        /// <para>The name of the TokenVault.</para>
        /// </summary>
        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
