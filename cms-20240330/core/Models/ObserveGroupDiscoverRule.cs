// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupDiscoverRule : TeaModel {
        /// <summary>
        /// <para>规则是否启用；false 时数据面跳过该规则（不匹配 / 不打标 / 不下发）。</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>（旧）单实体类型，向后兼容，优先用 entityTypes。</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>实体类型列表，支持一条规则跨多类型匹配（如 acs.ecs.instance/acs.rds.instance/acs.arms.service）。</para>
        /// </summary>
        [NameInMap("entityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>规则创建时间（Unix 毫秒时间戳），控制台展示用。</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>手动指定的实例 ID 列表（枚举型，含 1.0 手动实例同步）。</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>名称匹配规则。</para>
        /// </summary>
        [NameInMap("nameRules")]
        [Validation(Required=false)]
        public ObserveGroupDiscoverRuleNameRules NameRules { get; set; }
        public class ObserveGroupDiscoverRuleNameRules : TeaModel {
            /// <summary>
            /// <para>名称匹配逻辑。</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>名称条件列表。</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ObserveGroupDiscoverRuleNameRulesTags> Tags { get; set; }
            public class ObserveGroupDiscoverRuleNameRulesTags : TeaModel {
                /// <summary>
                /// <para>匹配操作。</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>匹配值列表。</para>
                /// </summary>
                [NameInMap("tagValues")]
                [Validation(Required=false)]
                public List<string> TagValues { get; set; }

            }

        }

        /// <summary>
        /// <para>按地域过滤的 region ID 列表。</para>
        /// </summary>
        [NameInMap("regionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>按资源组过滤。</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>规则稳定 ID（编辑/删除/启停锚点），格式 dr-&lt;16位hash&gt;。</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>匹配方式：byTag / byResourceGroup / byInstanceName / byManual / bySpl。</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>适用范围：all（全部实体类型，独占）/ entity（指定实体类型）。</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>完整 SPL 表达式（高级配置）；非空时优先生效，覆盖其它过滤字段。</para>
        /// </summary>
        [NameInMap("spl")]
        [Validation(Required=false)]
        public string Spl { get; set; }

        /// <summary>
        /// <para>标签匹配规则。</para>
        /// </summary>
        [NameInMap("tagRules")]
        [Validation(Required=false)]
        public ObserveGroupDiscoverRuleTagRules TagRules { get; set; }
        public class ObserveGroupDiscoverRuleTagRules : TeaModel {
            /// <summary>
            /// <para>标签匹配逻辑。</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>标签条件列表。</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ObserveGroupDiscoverRuleTagRulesTags> Tags { get; set; }
            public class ObserveGroupDiscoverRuleTagRulesTags : TeaModel {
                /// <summary>
                /// <para>匹配操作。</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>标签键。</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>标签值列表。</para>
                /// </summary>
                [NameInMap("tagValues")]
                [Validation(Required=false)]
                public List<string> TagValues { get; set; }

            }

        }

        /// <summary>
        /// <para>规则所属用户 UID。</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
