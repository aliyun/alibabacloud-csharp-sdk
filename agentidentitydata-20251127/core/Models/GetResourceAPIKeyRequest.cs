// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceAPIKeyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-api-key-provider</para>
        /// </summary>
        [NameInMap("ResourceCredentialProviderName")]
        [Validation(Required=false)]
        public string ResourceCredentialProviderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyAgImFsZyI6ICJSUzI1N****</para>
        /// </summary>
        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
