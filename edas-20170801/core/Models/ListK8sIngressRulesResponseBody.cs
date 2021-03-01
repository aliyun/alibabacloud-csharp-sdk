// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sIngressRulesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IngressConfigs")]
        [Validation(Required=false)]
        public List<ListK8sIngressRulesResponseBodyIngressConfigs> IngressConfigs { get; set; }
        public class ListK8sIngressRulesResponseBodyIngressConfigs : TeaModel {
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("IngressRules")]
            [Validation(Required=false)]
            public List<ListK8sIngressRulesResponseBodyIngressConfigsIngressRules> IngressRules { get; set; }
            public class ListK8sIngressRulesResponseBodyIngressConfigsIngressRules : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("IngressPaths")]
                [Validation(Required=false)]
                public List<ListK8sIngressRulesResponseBodyIngressConfigsIngressRulesIngressPaths> IngressPaths { get; set; }
                public class ListK8sIngressRulesResponseBodyIngressConfigsIngressRulesIngressPaths : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public int? ServicePort { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
