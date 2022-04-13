// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sSecretsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sSecretsResponseBodyResult Result { get; set; }
        public class ListK8sSecretsResponseBodyResult : TeaModel {
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListK8sSecretsResponseBodyResultSecrets> Secrets { get; set; }
            public class ListK8sSecretsResponseBodyResultSecrets : TeaModel {
                public bool? Base64Encoded { get; set; }
                public ListK8sSecretsResponseBodyResultSecretsCertDetail CertDetail { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsCertDetail : TeaModel {
                    [NameInMap("DomainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }
                public string CertId { get; set; }
                public string CertRegionId { get; set; }
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string CreationTime { get; set; }
                public List<ListK8sSecretsResponseBodyResultSecretsData> Data { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Name { get; set; }
                public string Namespace { get; set; }
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedApps> RelatedApps { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedApps : TeaModel {
                    public string AppId { get; set; }
                    public string AppName { get; set; }
                }
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules> RelatedIngressRules { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules : TeaModel {
                    public string Name { get; set; }
                    public string Namespace { get; set; }
                    public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps> RelatedApps { get; set; }
                    public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps : TeaModel {
                        public string AppId { get; set; }
                        public string AppName { get; set; }
                    }
                }
                public string Type { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

    }

}
