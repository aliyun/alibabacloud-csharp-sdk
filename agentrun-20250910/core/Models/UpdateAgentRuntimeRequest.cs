// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters for updating an agent runtime.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAgentRuntimeInput Body { get; set; }

    }

}
