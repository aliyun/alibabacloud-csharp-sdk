// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyStorageRequirementsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of storage requirements</para>
        /// </summary>
        [NameInMap("storageRequirements")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirements> StorageRequirements { get; set; }
        public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirements : TeaModel {
            /// <summary>
            /// <para>Collection of AddonReleases.</para>
            /// </summary>
            [NameInMap("addonReleaseNames")]
            [Validation(Required=false)]
            public List<string> AddonReleaseNames { get; set; }

            /// <summary>
            /// <para>API Version</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>Resource kind</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pod</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>Metadata</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsMetadata Metadata { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsMetadata : TeaModel {
                /// <summary>
                /// <para>Annotations</para>
                /// </summary>
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public Dictionary<string, string> Annotations { get; set; }

                /// <summary>
                /// <para>Resource labels</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>Resource name</para>
                /// 
                /// <b>Example:</b>
                /// <para>pod-1234567</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Namespace</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prom</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            /// <summary>
            /// <para>Resource spec</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsSpec Spec { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsSpec : TeaModel {
                /// <summary>
                /// <para>Instance ID, which can be specified if you need to pinpoint to the instance level. It depends on the data in EntityStore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-xxxxx</para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Prom Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp122p85gthbniw8rsu9</para>
                /// </summary>
                [NameInMap("instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>Prom instance name</para>
                /// 
                /// <b>Example:</b>
                /// <para>category_predict</para>
                /// </summary>
                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Optional parameter, determined based on the current environment type</para>
                /// 
                /// <b>Example:</b>
                /// <para>datagrid_cdm</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>Region</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Storage sharing scope: Environment | Region | Workspace | Custom</para>
                /// 
                /// <b>Example:</b>
                /// <para>Region</para>
                /// </summary>
                [NameInMap("shareScope")]
                [Validation(Required=false)]
                public string ShareScope { get; set; }

                /// <summary>
                /// <para>Instance storage type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>Tags to be applied to the target storage (injected as system tags)</para>
                /// </summary>
                [NameInMap("systemTags")]
                [Validation(Required=false)]
                public Dictionary<string, string> SystemTags { get; set; }

                /// <summary>
                /// <para>Tags to be applied to the target storage (injected as regular tags)</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public Dictionary<string, string> Tags { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Workspace</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>Storage requirement status</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsStatus Status { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsStatus : TeaModel {
                /// <summary>
                /// <para>Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-uqm3ket1t0u</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Internal URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.xxxxxx">http://192.168.xxxxxx</a></para>
                /// </summary>
                [NameInMap("interUrl")]
                [Validation(Required=false)]
                public string InterUrl { get; set; }

                /// <summary>
                /// <para>External URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://100.100.xxxxxx">http://100.100.xxxxxx</a></para>
                /// </summary>
                [NameInMap("intraUrl")]
                [Validation(Required=false)]
                public string IntraUrl { get; set; }

                /// <summary>
                /// <para>存储需求名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>sr-xxxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>存储需求项目</para>
                /// 
                /// <b>Example:</b>
                /// <para>jiuwu_algo</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>Prom\&quot;s metric center</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("promMetricStore")]
                [Validation(Required=false)]
                public string PromMetricStore { get; set; }

                /// <summary>
                /// <para>Region</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Instance storage type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>Workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

        }

    }

}
