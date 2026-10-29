// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderSCIMRequest : TeaModel {
        /// <summary>
        /// <para>Submits the business parameters as described in this API. The body parameters of the public API are mapped to the backend wrapper by the gateway. Do not mix them with the backend direct connection body wrapper.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIdentityProviderSCIMRequestBody Body { get; set; }
        public class UpdateIdentityProviderSCIMRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable synchronization. Do not set this parameter to true during CustomSSO initialization. You can only update this parameter by calling UpdateIdentityProviderSCIM later. Determine the result based on the operationStatus field.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

    }

}
