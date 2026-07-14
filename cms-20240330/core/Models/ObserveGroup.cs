// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroup : TeaModel {
        /// <summary>
        /// <para>The UID of the Alibaba Cloud account to which the group belongs.</para>
        /// </summary>
        [NameInMap("aliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>The creation time in UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
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
        /// <para>The number of entities in each category. The key is the category domain (acs for cloud services, apm, or rum, which is extensible). The value is the number of entities in that category that belong to this group. Returned only when withEntityCount is set to true.</para>
        /// </summary>
        [NameInMap("entityCounts")]
        [Validation(Required=false)]
        public Dictionary<string, int?> EntityCounts { get; set; }

        /// <summary>
        /// <para>The extended information as a JSON string, which carries alert templates, alert contact groups, and suspension policies.</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether the current user has followed this group. This value is used as the filter criterion for the My Favorites feature.</para>
        /// </summary>
        [NameInMap("favorited")]
        [Validation(Required=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// <para>The globally unique ID of the observability group. Format: og-&lt;16-character hash&gt;. Used uniformly across metrics, alerts, and consoles.</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the observability group. Must be unique within the same workspace.</para>
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
        /// <para>The health status of the group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: unknown (placeholder).</description></item>
        /// <item><description>1: healthy.</description></item>
        /// <item><description>0: unhealthy.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("health")]
        [Validation(Required=false)]
        public int? Health { get; set; }

        /// <summary>
        /// <para>The last modification time in UTC format: yyyy-MM-ddTHH:mm:ssZ. Automatically updated when any resource attribute changes.</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>Specifies whether og_entity_info metric output is enabled. When enabled, the data plane writes the group membership information to the target Prometheus instance.</para>
        /// </summary>
        [NameInMap("ogEntityInfoEnabled")]
        [Validation(Required=false)]
        public bool? OgEntityInfoEnabled { get; set; }

        /// <summary>
        /// <para>The set of Prometheus instances to which og_entity_info is written. Includes two source types: system (automatically identified by the system) and custom (user-defined).</para>
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
        /// <para>The region ID to which the group belongs.</para>
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
        /// <para>The resource tags (Alibaba Cloud standard tags) as an array of key-value pairs.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ObserveGroupTags> Tags { get; set; }
        public class ObserveGroupTags : TeaModel {
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
        /// <para>The workspace ID to which the group belongs. This value is set at the workspace level and cannot be changed after creation.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
