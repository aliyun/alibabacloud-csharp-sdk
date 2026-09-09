// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationFederatedCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The application federated credential ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afc_aaaaa1111</para>
        /// </summary>
        [NameInMap("ApplicationFederatedCredentialId")]
        [Validation(Required=false)]
        public string ApplicationFederatedCredentialId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The attribute mappings.</para>
        /// </summary>
        [NameInMap("AttributeMappings")]
        [Validation(Required=false)]
        public List<UpdateApplicationFederatedCredentialRequestAttributeMappings> AttributeMappings { get; set; }
        public class UpdateApplicationFederatedCredentialRequestAttributeMappings : TeaModel {
            /// <summary>
            /// <para>The source value expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Append(client.applicationFederatedCredentialId, &quot;:&quot;, cert.subject.CN, &quot;:&quot;, cert.serialNumber)</para>
            /// </summary>
            [NameInMap("SourceValueExpression")]
            [Validation(Required=false)]
            public string SourceValueExpression { get; set; }

            /// <summary>
            /// <para>The target field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client.activeSubjectUrn</para>
            /// </summary>
            [NameInMap("TargetField")]
            [Validation(Required=false)]
            public string TargetField { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The OIDC structured configuration.</para>
        /// </summary>
        [NameInMap("OidcVerificationConfig")]
        [Validation(Required=false)]
        public UpdateApplicationFederatedCredentialRequestOidcVerificationConfig OidcVerificationConfig { get; set; }
        public class UpdateApplicationFederatedCredentialRequestOidcVerificationConfig : TeaModel {
            /// <summary>
            /// <para>The Azure VM scenario configuration.</para>
            /// </summary>
            [NameInMap("AzureVmConfig")]
            [Validation(Required=false)]
            public UpdateApplicationFederatedCredentialRequestOidcVerificationConfigAzureVmConfig AzureVmConfig { get; set; }
            public class UpdateApplicationFederatedCredentialRequestOidcVerificationConfigAzureVmConfig : TeaModel {
                /// <summary>
                /// <para>The principal ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5dee234a-1b4c-4ad7-a19f-fxxxxx</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The Azure resource group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_default</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <para>The subscription ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4342a1f4-7e5d-4371-97dc-d4f33f4xxxx</para>
                /// </summary>
                [NameInMap("SubscriptionId")]
                [Validation(Required=false)]
                public string SubscriptionId { get; set; }

                /// <summary>
                /// <para>The list of virtual machine names.</para>
                /// </summary>
                [NameInMap("VmNames")]
                [Validation(Required=false)]
                public List<string> VmNames { get; set; }

            }

            /// <summary>
            /// <para>The GCP VM scenario configuration.</para>
            /// </summary>
            [NameInMap("GcpVmConfig")]
            [Validation(Required=false)]
            public UpdateApplicationFederatedCredentialRequestOidcVerificationConfigGcpVmConfig GcpVmConfig { get; set; }
            public class UpdateApplicationFederatedCredentialRequestOidcVerificationConfigGcpVmConfig : TeaModel {
                /// <summary>
                /// <para>The list of VM instance IDs.</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                /// <summary>
                /// <para>The GCP project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>turnkey-axiom-475109-xx</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The sub claim corresponding to the service account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("ServiceAccountId")]
                [Validation(Required=false)]
                public string ServiceAccountId { get; set; }

            }

            /// <summary>
            /// <para>The generic scenario configuration.</para>
            /// </summary>
            [NameInMap("GenericConfig")]
            [Validation(Required=false)]
            public UpdateApplicationFederatedCredentialRequestOidcVerificationConfigGenericConfig GenericConfig { get; set; }
            public class UpdateApplicationFederatedCredentialRequestOidcVerificationConfigGenericConfig : TeaModel {
                /// <summary>
                /// <para>The subject identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_subject</para>
                /// </summary>
                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

            }

            /// <summary>
            /// <para>The Kubernetes scenario configuration.</para>
            /// </summary>
            [NameInMap("KubernetesConfig")]
            [Validation(Required=false)]
            public UpdateApplicationFederatedCredentialRequestOidcVerificationConfigKubernetesConfig KubernetesConfig { get; set; }
            public class UpdateApplicationFederatedCredentialRequestOidcVerificationConfigKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>The K8s namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The pod name prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-pod-</para>
                /// </summary>
                [NameInMap("PodNamePrefix")]
                [Validation(Required=false)]
                public string PodNamePrefix { get; set; }

                /// <summary>
                /// <para>The K8s service account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sa</para>
                /// </summary>
                [NameInMap("ServiceAccountName")]
                [Validation(Required=false)]
                public string ServiceAccountName { get; set; }

            }

            /// <summary>
            /// <para>The OIDC scenario profile. Different profiles correspond to different configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>generic</description></item>
            /// <item><description>kubernetes</description></item>
            /// <item><description>gcp_vm</description></item>
            /// <item><description>azure_vm</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

        }

        /// <summary>
        /// <para>The PKCS#7 structured configuration.</para>
        /// </summary>
        [NameInMap("Pkcs7VerificationConfig")]
        [Validation(Required=false)]
        public UpdateApplicationFederatedCredentialRequestPkcs7VerificationConfig Pkcs7VerificationConfig { get; set; }
        public class UpdateApplicationFederatedCredentialRequestPkcs7VerificationConfig : TeaModel {
            /// <summary>
            /// <para>The list of VM instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

        }

        /// <summary>
        /// <para>The verification condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IsNullOrEmpty(&quot;&quot;)</para>
        /// </summary>
        [NameInMap("VerificationCondition")]
        [Validation(Required=false)]
        public string VerificationCondition { get; set; }

    }

}
