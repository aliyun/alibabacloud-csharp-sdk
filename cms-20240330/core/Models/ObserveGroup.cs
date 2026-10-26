// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroup : TeaModel {
        /// <summary>
        /// <para>分组归属的阿里云主账号 UID。</para>
        /// </summary>
        [NameInMap("aliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>创建时间，UTC 格式 yyyy-MM-ddTHH:mm:ssZ。</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>观测分组描述（业务用途说明）。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>实体发现规则列表，定义分组自动匹配哪些实体。</para>
        /// </summary>
        [NameInMap("discoverRules")]
        [Validation(Required=false)]
        public List<ObserveGroupDiscoverRule> DiscoverRules { get; set; }

        /// <summary>
        /// <para>各分类实体数量。key=分类 domain（acs=云产品 / apm / rum，可扩展），value=该分类下属于本分组的实体数。仅 withEntityCount=true 时返回。</para>
        /// </summary>
        [NameInMap("entityCounts")]
        [Validation(Required=false)]
        public Dictionary<string, int?> EntityCounts { get; set; }

        /// <summary>
        /// <para>扩展信息（JSON 字符串，承载告警模板/联系人组/暂停策略等）。</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>当前用户是否已关注该分组（「我的关注」筛选依据）。</para>
        /// </summary>
        [NameInMap("favorited")]
        [Validation(Required=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// <para>观测分组全局唯一 ID，格式 og-&lt;16位hash&gt;，指标/告警/控制台统一使用。</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>观测分组名称（同 workspace 下唯一）。</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>观测分组类型。</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>分组健康状态：-1 未知（占位）/ 1 健康 / 0 不健康。</para>
        /// </summary>
        [NameInMap("health")]
        [Validation(Required=false)]
        public int? Health { get; set; }

        /// <summary>
        /// <para>最后修改时间，UTC 格式 yyyy-MM-ddTHH:mm:ssZ。资源任意属性变更时自动更新。</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>是否开启 og_entity_info 指标输出。开启后数据面会把本分组归属写入目标 Prometheus 实例。</para>
        /// </summary>
        [NameInMap("ogEntityInfoEnabled")]
        [Validation(Required=false)]
        public bool? OgEntityInfoEnabled { get; set; }

        /// <summary>
        /// <para>写入 og_entity_info 的 Prometheus 实例集合，包含系统自动识别(system)和用户自定义(custom)两类来源。</para>
        /// </summary>
        [NameInMap("ogEntityInfoPromInstances")]
        [Validation(Required=false)]
        public List<ObserveGroupPromInstance> OgEntityInfoPromInstances { get; set; }

        /// <summary>
        /// <para>仅 synced_from_1_0 时填值，存 1.0 应用分组的 product_group.id。</para>
        /// </summary>
        [NameInMap("originGroupId")]
        [Validation(Required=false)]
        public string OriginGroupId { get; set; }

        /// <summary>
        /// <para>分组所属地域 ID。</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>阿里云资源组 ID。</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>数据来源：native_2_0（2.0 原生）/ synced_from_1_0（从 1.0 应用分组同步）。</para>
        /// </summary>
        [NameInMap("sourceOrigin")]
        [Validation(Required=false)]
        public string SourceOrigin { get; set; }

        /// <summary>
        /// <para>资源标签（阿里云标准标签），键值对数组。</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ObserveGroupTags> Tags { get; set; }
        public class ObserveGroupTags : TeaModel {
            /// <summary>
            /// <para>标签键。</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>标签值。</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>分组归属的 workspace ID（workspace 级归属，创建后不可变）。</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
