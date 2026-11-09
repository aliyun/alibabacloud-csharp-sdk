// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class RebuildSandboxRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the service registration endpoint. This parameter is optional. If you specify this parameter, the operation targets the runtime instance that corresponds to the service registration endpoint under the agent. If you omit this parameter, the default latest runtime identity is used. Pass the service registration endpoint ID instead of the service registration endpoint name. You must keep this parameter consistent when you query instances, commit rebuilds, and query nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>se-7f3a92c1</para>
        /// </summary>
        [NameInMap("serviceEndpointId")]
        [Validation(Required=false)]
        public string ServiceEndpointId { get; set; }

    }

}
