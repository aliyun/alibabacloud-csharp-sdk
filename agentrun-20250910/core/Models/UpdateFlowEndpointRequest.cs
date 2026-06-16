// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateFlowEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Update Flow Endpoint Input Parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateFlowEndpointInput Body { get; set; }

    }

}
