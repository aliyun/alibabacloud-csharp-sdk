// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// <para>Complete configuration information required to create a workflow, including the workflow name, definition, and execution role.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateFlowInput Body { get; set; }

    }

}
