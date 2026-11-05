// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderSCIMRequest : TeaModel {
        /// <summary>
        /// <para>The business parameters submitted in the request body. The body parameters of public APIs are mapped to backend wrappers by the gateway and must not be mixed with direct backend body wrappers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIdentityProviderSCIMRequestBody Body { get; set; }
        public class UpdateIdentityProviderSCIMRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable SCIM synchronization. Do not set this parameter to true during CustomSSO initialization. You can update this parameter only by calling UpdateIdentityProviderSCIM. Check the operationStatus field to determine the result.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

    }

}
