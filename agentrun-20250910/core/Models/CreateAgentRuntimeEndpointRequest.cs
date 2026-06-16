// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Create agent runtime endpoint input</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentRuntimeEndpointInput Body { get; set; }

    }

}
