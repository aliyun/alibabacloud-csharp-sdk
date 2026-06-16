// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>Request parameters for creating an agent runtime</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentRuntimeInput Body { get; set; }

    }

}
