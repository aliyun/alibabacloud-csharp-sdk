// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The new configuration for the credential.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCredentialInput Body { get; set; }

    }

}
