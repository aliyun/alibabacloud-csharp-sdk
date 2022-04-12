// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sIngressRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListK8sIngressRulesResponseBodyData> Data { get; set; }
        public class ListK8sIngressRulesResponseBodyData : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("IngressConfs")]
            [Validation(Required=false)]
            public List<ListK8sIngressRulesResponseBodyDataIngressConfs> IngressConfs { get; set; }
            public class ListK8sIngressRulesResponseBodyDataIngressConfs : TeaModel {
                [NameInMap("AlbId")]
                [Validation(Required=false)]
                public string AlbId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DashboardUrl")]
                [Validation(Required=false)]
                public string DashboardUrl { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("IngressType")]
                [Validation(Required=false)]
                public string IngressType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListK8sIngressRulesResponseBodyDataIngressConfsRules> Rules { get; set; }
                public class ListK8sIngressRulesResponseBodyDataIngressConfsRules : TeaModel {
                    [NameInMap("EnableTls")]
                    [Validation(Required=false)]
                    public bool? EnableTls { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Paths")]
                    [Validation(Required=false)]
                    public List<ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths> Paths { get; set; }
                    public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        [NameInMap("Backend")]
                        [Validation(Required=false)]
                        public ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend Backend { get; set; }
                        public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend : TeaModel {
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }
                            [NameInMap("ServicePort")]
                            [Validation(Required=false)]
                            public string ServicePort { get; set; }
                        };

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

                [NameInMap("SslRedirect")]
                [Validation(Required=false)]
                public bool? SslRedirect { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
