// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class RebuildSandboxRequest : TeaModel {
        /// <summary>
        /// <para>The service registration endpoint ID. This parameter is optional. If specified, the operation targets the runtime instance corresponding to the service registration endpoint under the agent. If omitted, the default latest runtime identity is used. Pass the service registration endpoint ID, not the service registration endpoint name. Keep this parameter consistent when querying instances, committing the rebuild, and querying nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>se-7f3a92c1</para>
        /// </summary>
        [NameInMap("serviceEndpointId")]
        [Validation(Required=false)]
        public string ServiceEndpointId { get; set; }

    }

}
