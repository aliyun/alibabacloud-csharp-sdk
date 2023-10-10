// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sSecretsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned query results of Kubernetes Secrets.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sSecretsResponseBodyResult Result { get; set; }
        public class ListK8sSecretsResponseBodyResult : TeaModel {
            /// <summary>
            /// The information about Kubernetes Secrets.
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListK8sSecretsResponseBodyResultSecrets> Secrets { get; set; }
            public class ListK8sSecretsResponseBodyResultSecrets : TeaModel {
                /// <summary>
                /// Indicates whether the data is Base64-encoded. Valid values:
                /// 
                /// *   true: The data is Base64-encoded.
                /// *   false: The data is not Base64-encoded.
                /// </summary>
                [NameInMap("Base64Encoded")]
                [Validation(Required=false)]
                public bool? Base64Encoded { get; set; }

                /// <summary>
                /// The details of the Secure Sockets Layer (SSL) certificate.
                /// </summary>
                [NameInMap("CertDetail")]
                [Validation(Required=false)]
                public ListK8sSecretsResponseBodyResultSecretsCertDetail CertDetail { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsCertDetail : TeaModel {
                    /// <summary>
                    /// Domain names that are associated with the SSL certificate.
                    /// </summary>
                    [NameInMap("DomainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                    /// <summary>
                    /// The time when the SSL certificate expired.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// The certificate authority (CA) that issued the SSL certificate.
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// The time when the SSL certificate started to take effect.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The state of the SSL certificate. Valid values:
                    /// 
                    /// *   normal: The SSL certificate is valid.
                    /// *   invalid: The SSL certificate is invalid.
                    /// *   expired: The SSL certificate has expired.
                    /// *   not_yet_valid: The SSL certificate is currently invalid.
                    /// *   about_to_expire: The SSL certificate is about to expire.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The ID of the certificate provided by Alibaba Cloud Certificate Management Service.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// The region in which the certificate is stored.
                /// </summary>
                [NameInMap("CertRegionId")]
                [Validation(Required=false)]
                public string CertRegionId { get; set; }

                /// <summary>
                /// The ID of the cluster in Enterprise Distributed Application Service (EDAS).
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The time when the Secret was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The data of the Kubernetes Secret.
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsData> Data { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsData : TeaModel {
                    /// <summary>
                    /// The user-defined key of the Kubernetes Secret.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The user-defined value of the Kubernetes Secret.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The name of the Secret. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 63 characters in length.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the Kubernetes cluster.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// Applications that use the Secret.
                /// </summary>
                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedApps> RelatedApps { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedApps : TeaModel {
                    /// <summary>
                    /// The ID of the application.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The name of the application.
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// Rules in the Ingress that is associated with the Secret.
                /// </summary>
                [NameInMap("RelatedIngressRules")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules> RelatedIngressRules { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules : TeaModel {
                    /// <summary>
                    /// The name of the rule in the Ingress.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespaces of the Kubernetes cluster.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// Aplications that are associated with the Ingress.
                    /// </summary>
                    [NameInMap("RelatedApps")]
                    [Validation(Required=false)]
                    public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps> RelatedApps { get; set; }
                    public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps : TeaModel {
                        /// <summary>
                        /// The ID of the application.
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// The name of the EDAS application.
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                    }

                }

                /// <summary>
                /// The type of the Secret. Valid values:
                /// 
                /// *   Opaque: user-defined data
                /// *   kubernetes.io/tls: Transport Layer Security (TLS) certificate
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The total number of entries that are returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
