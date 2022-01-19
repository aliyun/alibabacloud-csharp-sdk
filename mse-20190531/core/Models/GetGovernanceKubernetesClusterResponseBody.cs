// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGovernanceKubernetesClusterResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class GetGovernanceKubernetesClusterResponseBodyData : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("K8sVersion")]
            [Validation(Required=false)]
            public string K8sVersion { get; set; }
            [NameInMap("NamespaceInfos")]
            [Validation(Required=false)]
            public string NamespaceInfos { get; set; }
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<GetGovernanceKubernetesClusterResponseBodyDataNamespaces> Namespaces { get; set; }
            public class GetGovernanceKubernetesClusterResponseBodyDataNamespaces : TeaModel {
                public string Name { get; set; }
                public string Tags { get; set; }
            }
            [NameInMap("PilotStartTime")]
            [Validation(Required=false)]
            public string PilotStartTime { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
