// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The idempotent request token. For the same tenant, model API, and parameters, you can use the original client token to retry the deletion if a background deletion fails. A conflict is returned if an active operation is in progress or if the configuration has been replaced by a newer operation. A replay of a fully completed deletion returns an empty success response, but using the same token for a different target is still rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delete-model-api-client-token-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. If you set this parameter to true, the system performs the same synchronous admission checks as a real deletion, but does not create a deletion run or idempotent record, stop the service, or delete the API or associated configurations. If you set this parameter to false or leave it empty, the actual deletion is accepted.</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
