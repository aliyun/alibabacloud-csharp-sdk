// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationFederatedCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The application federated credential object.</para>
        /// </summary>
        [NameInMap("ApplicationFederatedCredential")]
        [Validation(Required=false)]
        public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredential ApplicationFederatedCredential { get; set; }
        public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredential : TeaModel {
            /// <summary>
            /// <para>The application federated credential ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>afc_aaaaa1111</para>
            /// </summary>
            [NameInMap("ApplicationFederatedCredentialId")]
            [Validation(Required=false)]
            public string ApplicationFederatedCredentialId { get; set; }

            /// <summary>
            /// <para>The application federated credential name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApplicationFederatedCredentialName")]
            [Validation(Required=false)]
            public string ApplicationFederatedCredentialName { get; set; }

            /// <summary>
            /// <para>The application federated credential type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oidc</para>
            /// </summary>
            [NameInMap("ApplicationFederatedCredentialType")]
            [Validation(Required=false)]
            public string ApplicationFederatedCredentialType { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
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
            public List<GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialAttributeMappings> AttributeMappings { get; set; }
            public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialAttributeMappings : TeaModel {
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758785994982</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The application federated credential description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The federated trust source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fcp_asda1dasdxxxx</para>
            /// </summary>
            [NameInMap("FederatedCredentialProviderId")]
            [Validation(Required=false)]
            public string FederatedCredentialProviderId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The last used time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758785994982</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>The OIDC structured configuration.</para>
            /// </summary>
            [NameInMap("OidcVerificationConfig")]
            [Validation(Required=false)]
            public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfig OidcVerificationConfig { get; set; }
            public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfig : TeaModel {
                /// <summary>
                /// <para>The Azure VM scenario configuration.</para>
                /// </summary>
                [NameInMap("AzureVmConfig")]
                [Validation(Required=false)]
                public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigAzureVmConfig AzureVmConfig { get; set; }
                public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigAzureVmConfig : TeaModel {
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
                public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigGcpVmConfig GcpVmConfig { get; set; }
                public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigGcpVmConfig : TeaModel {
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
                    /// <para>The subject corresponding to the service account.</para>
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
                public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigGenericConfig GenericConfig { get; set; }
                public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigGenericConfig : TeaModel {
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
                public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigKubernetesConfig KubernetesConfig { get; set; }
                public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialOidcVerificationConfigKubernetesConfig : TeaModel {
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
                    /// <para>test-pod</para>
                    /// </summary>
                    [NameInMap("PodNamePrefix")]
                    [Validation(Required=false)]
                    public string PodNamePrefix { get; set; }

                    /// <summary>
                    /// <para>The K8s service account name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
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
            public GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialPkcs7VerificationConfig Pkcs7VerificationConfig { get; set; }
            public class GetApplicationFederatedCredentialResponseBodyApplicationFederatedCredentialPkcs7VerificationConfig : TeaModel {
                /// <summary>
                /// <para>The list of allowed instance IDs.</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

            }

            /// <summary>
            /// <para>The application federated credential status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758785994982</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The verification condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equals(cert.subject.CN, &quot;test&quot;)</para>
            /// </summary>
            [NameInMap("VerificationCondition")]
            [Validation(Required=false)]
            public string VerificationCondition { get; set; }

            /// <summary>
            /// <para>The verification mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>freedom: Free mode.</description></item>
            /// <item><description>structured: Structured mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>structured</para>
            /// </summary>
            [NameInMap("VerificationMode")]
            [Validation(Required=false)]
            public string VerificationMode { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
