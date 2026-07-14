// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupDiscoverRule : TeaModel {
        /// <summary>
        /// <para>Indicates whether the rule is enabled. If set to false, the data plane skips this rule and does not perform matching, tagging, or delivery.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The entity type (legacy). Retained for backward compatibility. Use entityTypes instead.</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The list of entity types. A single rule can match multiple types, such as acs.ecs.instance, acs.rds.instance, and acs.arms.service.</para>
        /// </summary>
        [NameInMap("entityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>The time when the rule was created, in UNIX millisecond timestamp format. This value is used for display in the console.</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The list of manually specified instance IDs in enumeration mode, including instances synchronized manually in version 1.0.</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The name matching rules.</para>
        /// </summary>
        [NameInMap("nameRules")]
        [Validation(Required=false)]
        public ObserveGroupDiscoverRuleNameRules NameRules { get; set; }
        public class ObserveGroupDiscoverRuleNameRules : TeaModel {
            /// <summary>
            /// <para>The name matching logic.</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The name condition list.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ObserveGroupDiscoverRuleNameRulesTags> Tags { get; set; }
            public class ObserveGroupDiscoverRuleNameRulesTags : TeaModel {
                /// <summary>
                /// <para>The matching operation.</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The matching value list.</para>
                /// </summary>
                [NameInMap("tagValues")]
                [Validation(Required=false)]
                public List<string> TagValues { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of region IDs used for filtering by region.</para>
        /// </summary>
        [NameInMap("regionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The resource group ID used for filtering.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The stable rule ID used as an anchor for editing, deleting, and enabling or disabling operations. Format: dr-&lt;16-character hash&gt;.</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The matching method. Valid values: byTag, byResourceGroup, byInstanceName, byManual, and bySpl.</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The applicable scope. Valid values: all (all entity types, exclusive) and entity (specified entity types).</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The full SPL expression for advanced configuration. If this parameter is not empty, it takes precedence over other filter fields.</para>
        /// </summary>
        [NameInMap("spl")]
        [Validation(Required=false)]
        public string Spl { get; set; }

        /// <summary>
        /// <para>The tag matching rules.</para>
        /// </summary>
        [NameInMap("tagRules")]
        [Validation(Required=false)]
        public ObserveGroupDiscoverRuleTagRules TagRules { get; set; }
        public class ObserveGroupDiscoverRuleTagRules : TeaModel {
            /// <summary>
            /// <para>The tag matching logic.</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The tag condition list.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ObserveGroupDiscoverRuleTagRulesTags> Tags { get; set; }
            public class ObserveGroupDiscoverRuleTagRulesTags : TeaModel {
                /// <summary>
                /// <para>The matching operation.</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value list.</para>
                /// </summary>
                [NameInMap("tagValues")]
                [Validation(Required=false)]
                public List<string> TagValues { get; set; }

            }

        }

        /// <summary>
        /// <para>The UID of the user to whom the rule belongs.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
