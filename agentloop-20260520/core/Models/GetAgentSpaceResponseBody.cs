// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetAgentSpaceResponseBody : TeaModel {
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        [NameInMap("cmsWorkspace")]
        [Validation(Required=false)]
        public string CmsWorkspace { get; set; }

        [NameInMap("cmsWorkspaceBindType")]
        [Validation(Required=false)]
        public string CmsWorkspaceBindType { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("mseNamespace")]
        [Validation(Required=false)]
        public GetAgentSpaceResponseBodyMseNamespace MseNamespace { get; set; }
        public class GetAgentSpaceResponseBodyMseNamespace : TeaModel {
            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

        }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
