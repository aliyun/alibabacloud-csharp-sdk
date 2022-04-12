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
        public List<ListK8sSecretsResponseBodyResult> Result { get; set; }
        public class ListK8sSecretsResponseBodyResult : TeaModel {
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListK8sSecretsResponseBodyResultSecrets> Secrets { get; set; }
            public class ListK8sSecretsResponseBodyResultSecrets : TeaModel {
                [NameInMap("Base64Encoded")]
                [Validation(Required=false)]
                public bool? Base64Encoded { get; set; }

                [NameInMap("CertDetail")]
                [Validation(Required=false)]
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
                    [NameInMap("KeySize")]
                    [Validation(Required=false)]
                    public int? KeySize { get; set; }
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                };

                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("CertRegionId")]
                [Validation(Required=false)]
                public string CertRegionId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsData> Data { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsData : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedApps> RelatedApps { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedApps : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                [NameInMap("RelatedIngressRules")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules> RelatedIngressRules { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("RelatedApps")]
                    [Validation(Required=false)]
                    public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps> RelatedApps { get; set; }
                    public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
