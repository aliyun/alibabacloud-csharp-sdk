// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyStorageRequirementsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of storage requirements.</para>
        /// </summary>
        [NameInMap("storageRequirements")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirements> StorageRequirements { get; set; }
        public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirements : TeaModel {
            /// <summary>
            /// <para>A collection of AddonRelease names.</para>
            /// </summary>
            [NameInMap("addonReleaseNames")]
            [Validation(Required=false)]
            public List<string> AddonReleaseNames { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>The kind of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pod</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsMetadata Metadata { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsMetadata : TeaModel {
                /// <summary>
                /// <para>The annotations.</para>
                /// </summary>
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public Dictionary<string, string> Annotations { get; set; }

                /// <summary>
                /// <para>The resource labels.</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pod-1234567</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prom</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            /// <summary>
            /// <para>The spec of the resource.</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsSpec Spec { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsSpec : TeaModel {
                /// <summary>
                /// <para>The instance ID. Specify this parameter to query data at the instance level. This parameter depends on data in EntityStore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-xxxxx</para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The ID of the Prometheus instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp122p85gthbniw8rsu9</para>
                /// </summary>
                [NameInMap("instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>The name of the Prometheus instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category_predict</para>
                /// </summary>
                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Optional. The project is determined based on the current environment type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datagrid_cdm</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The scope of storage sharing. Valid values: Environment, Region, Workspace, and Custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Region</para>
                /// </summary>
                [NameInMap("shareScope")]
                [Validation(Required=false)]
                public string ShareScope { get; set; }

                /// <summary>
                /// <para>The storage type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The tags that need to be added to the destination storage. The tags are injected as system tags.</para>
                /// </summary>
                [NameInMap("systemTags")]
                [Validation(Required=false)]
                public Dictionary<string, string> SystemTags { get; set; }

                /// <summary>
                /// <para>The tags that need to be added to the destination storage. The tags are injected as common tags.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public Dictionary<string, string> Tags { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The status of the storage requirement.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsStatus Status { get; set; }
            public class ListIntegrationPolicyStorageRequirementsResponseBodyStorageRequirementsStatus : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-uqm3ket1t0u</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The internal URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.xxxxxx">http://192.168.xxxxxx</a></para>
                /// </summary>
                [NameInMap("interUrl")]
                [Validation(Required=false)]
                public string InterUrl { get; set; }

                /// <summary>
                /// <para>The internal URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://100.100.xxxxxx">http://100.100.xxxxxx</a></para>
                /// </summary>
                [NameInMap("intraUrl")]
                [Validation(Required=false)]
                public string IntraUrl { get; set; }

                /// <summary>
                /// <para>The name of the storage requirement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sr-xxxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project for the storage requirement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jiuwu_algo</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The metric store of Prometheus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("promMetricStore")]
                [Validation(Required=false)]
                public string PromMetricStore { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The storage type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The workspace.</para>
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
