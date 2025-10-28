// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned query results of Kubernetes Secrets.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sSecretsResponseBodyResult Result { get; set; }
        public class ListK8sSecretsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The information about Kubernetes Secrets.</para>
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListK8sSecretsResponseBodyResultSecrets> Secrets { get; set; }
            public class ListK8sSecretsResponseBodyResultSecrets : TeaModel {
                /// <summary>
                /// <para>Indicates whether the data is Base64-encoded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The data is Base64-encoded.</description></item>
                /// <item><description>false: The data is not Base64-encoded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Base64Encoded")]
                [Validation(Required=false)]
                public bool? Base64Encoded { get; set; }

                /// <summary>
                /// <para>The details of the Secure Sockets Layer (SSL) certificate.</para>
                /// </summary>
                [NameInMap("CertDetail")]
                [Validation(Required=false)]
                public ListK8sSecretsResponseBodyResultSecretsCertDetail CertDetail { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsCertDetail : TeaModel {
                    /// <summary>
                    /// <para>Domain names that are associated with the SSL certificate.</para>
                    /// </summary>
                    [NameInMap("DomainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                    /// <summary>
                    /// <para>The time when the SSL certificate expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-02-22T02:32:41Z</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The certificate authority (CA) that issued the SSL certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN=GlobalSign Root CA, OU=Root CA, O=GlobalSign nv-sa, C=BE</para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The time when the SSL certificate started to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-02T22:40:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The state of the SSL certificate. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: The SSL certificate is valid.</description></item>
                    /// <item><description>invalid: The SSL certificate is invalid.</description></item>
                    /// <item><description>expired: The SSL certificate has expired.</description></item>
                    /// <item><description>not_yet_valid: The SSL certificate is currently invalid.</description></item>
                    /// <item><description>about_to_expire: The SSL certificate is about to expire.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the certificate provided by Alibaba Cloud Certificate Management Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The region in which the certificate is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertRegionId")]
                [Validation(Required=false)]
                public string CertRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the cluster in Enterprise Distributed Application Service (EDAS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>4472a6d3-f01d-4087-85a7-3dc52********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-cluster</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The time when the Secret was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-26T02:57:02Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The data of the Kubernetes Secret.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsData> Data { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsData : TeaModel {
                    /// <summary>
                    /// <para>The user-defined key of the Kubernetes Secret.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The user-defined value of the Kubernetes Secret.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>william</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the Secret. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 63 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-secret</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the Kubernetes cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Applications that use the Secret.</para>
                /// </summary>
                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedApps> RelatedApps { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedApps : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b08eeb18-8946-410c-a1ea-dbbc********</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The name of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-app</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>Rules in the Ingress that is associated with the Secret.</para>
                /// </summary>
                [NameInMap("RelatedIngressRules")]
                [Validation(Required=false)]
                public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules> RelatedIngressRules { get; set; }
                public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the rule in the Ingress.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testrulename</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespaces of the Kubernetes cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>Aplications that are associated with the Ingress.</para>
                    /// </summary>
                    [NameInMap("RelatedApps")]
                    [Validation(Required=false)]
                    public List<ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps> RelatedApps { get; set; }
                    public class ListK8sSecretsResponseBodyResultSecretsRelatedIngressRulesRelatedApps : TeaModel {
                        /// <summary>
                        /// <para>The ID of the application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6dc74432-5a35-4e68-8aaa-3700********</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The name of the EDAS application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>app-test</para>
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the Secret. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Opaque: user-defined data</description></item>
                /// <item><description>kubernetes.io/tls: Transport Layer Security (TLS) certificate</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Opaque</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
