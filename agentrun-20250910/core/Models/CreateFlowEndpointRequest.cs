// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFlowEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Request parameters for creating a flow endpoint</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateFlowEndpointInput Body { get; set; }

    }

}
