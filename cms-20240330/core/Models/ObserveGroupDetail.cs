// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupDetail : TeaModel {
        /// <summary>
        /// <para>The UID of the Alibaba Cloud account to which the group belongs.</para>
        /// </summary>
        [NameInMap("aliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>The time when the group was created, in UTC format (yyyy-MM-ddTHH:mm:ssZ).</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the observability group, which explains its business purpose.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of entity discovery rules that define which entities the group automatically matches.</para>
        /// </summary>
        [NameInMap("discoverRules")]
        [Validation(Required=false)]
        public List<ObserveGroupDiscoverRule> DiscoverRules { get; set; }

        /// <summary>
        /// <para>The statistics of entities in the group, categorized by entity type.</para>
        /// </summary>
        [NameInMap("entitySummaries")]
        [Validation(Required=false)]
        public List<ObserveGroupDetailEntitySummaries> EntitySummaries { get; set; }
        public class ObserveGroupDetailEntitySummaries : TeaModel {
            /// <summary>
            /// <para>The entity category.</para>
            /// </summary>
            [NameInMap("entityCategory")]
            [Validation(Required=false)]
            public string EntityCategory { get; set; }

            /// <summary>
            /// <para>The number of entities.</para>
            /// </summary>
            [NameInMap("entityCount")]
            [Validation(Required=false)]
            public int? EntityCount { get; set; }

            /// <summary>
            /// <para>The entity domain.</para>
            /// </summary>
            [NameInMap("entityDomain")]
            [Validation(Required=false)]
            public string EntityDomain { get; set; }

            /// <summary>
            /// <para>The entity type.</para>
            /// </summary>
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>The extended information in JSON string format, which carries alert templates, alert contact groups, suspension policies, and other configurations.</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether the current user has followed the group.</para>
        /// </summary>
        [NameInMap("favorited")]
        [Validation(Required=false)]
        public bool? Favorited { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the observability group. The name must be unique within the same workspace.</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the observability group.</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The time when the group was last modified, in UTC format (yyyy-MM-ddTHH:mm:ssZ). This value is automatically updated when any property of the resource changes.</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the og_entity_info metric output. When enabled, the data plane writes the group ownership information to the target Prometheus instance.</para>
        /// </summary>
        [NameInMap("ogEntityInfoEnabled")]
        [Validation(Required=false)]
        public bool? OgEntityInfoEnabled { get; set; }

        /// <summary>
        /// <para>The set of Prometheus instances to which og_entity_info is written. This includes two source types: system (automatically identified by the system) and custom (user-defined).</para>
        /// </summary>
        [NameInMap("ogEntityInfoPromInstances")]
        [Validation(Required=false)]
        public List<ObserveGroupPromInstance> OgEntityInfoPromInstances { get; set; }

        /// <summary>
        /// <para>The product_group.id of the version 1.0 application group. This parameter is valid only when sourceOrigin is set to synced_from_1_0.</para>
        /// </summary>
        [NameInMap("originGroupId")]
        [Validation(Required=false)]
        public string OriginGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the group.</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>native_2_0: created natively in version 2.0.</description></item>
        /// <item><description>synced_from_1_0: synchronized from a version 1.0 application group.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("sourceOrigin")]
        [Validation(Required=false)]
        public string SourceOrigin { get; set; }

        /// <summary>
        /// <para>The resource tags (Alibaba Cloud standard tags), represented as an array of key-value pairs.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ObserveGroupDetailTags> Tags { get; set; }
        public class ObserveGroupDetailTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID to which the group belongs. This value is set at the workspace level and cannot be changed after the group is created.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
