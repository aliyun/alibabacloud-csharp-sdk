// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        [NameInMap("IdpMetadata")]
        [Validation(Required=false)]
        public string IdpMetadata { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LoginEnabled")]
        [Validation(Required=false)]
        public bool? LoginEnabled { get; set; }

        [NameInMap("SyncEnabled")]
        [Validation(Required=false)]
        public bool? SyncEnabled { get; set; }

    }

}
