// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListAgentSpacesResponseBody : TeaModel {
        [NameInMap("agentSpaces")]
        [Validation(Required=false)]
        public List<ListAgentSpacesResponseBodyAgentSpaces> AgentSpaces { get; set; }
        public class ListAgentSpacesResponseBodyAgentSpaces : TeaModel {
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            [NameInMap("cmsWorkspace")]
            [Validation(Required=false)]
            public string CmsWorkspace { get; set; }

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
            public ListAgentSpacesResponseBodyAgentSpacesMseNamespace MseNamespace { get; set; }
            public class ListAgentSpacesResponseBodyAgentSpacesMseNamespace : TeaModel {
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

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
