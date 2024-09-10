// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitorGroupDynamicRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// None.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupRules")]
        [Validation(Required=false)]
        public List<PutMonitorGroupDynamicRuleRequestGroupRules> GroupRules { get; set; }
        public class PutMonitorGroupDynamicRuleRequestGroupRules : TeaModel {
            /// <summary>
            /// The cloud service to which the alert rule is applied. Valid values of N: 1 to 3. Valid values:
            /// 
            /// *   ecs: Elastic Compute Service (ECS)
            /// *   rds: ApsaraDB RDS
            /// *   slb: Server Load Balancer (SLB)
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The logical operator used between conditional expressions in the alert rule. Valid values of N: 1 to 3. Valid values:
            /// 
            /// *   and: The instances that meet all the conditional expressions are automatically added to the application group.
            /// *   or: The instances that meet one of the conditional expressions are automatically added to the application group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FilterRelation")]
            [Validation(Required=false)]
            public string FilterRelation { get; set; }

            /// <summary>
            /// None.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<PutMonitorGroupDynamicRuleRequestGroupRulesFilters> Filters { get; set; }
            public class PutMonitorGroupDynamicRuleRequestGroupRulesFilters : TeaModel {
                /// <summary>
                /// The method that is used to filter instances. Valid values of N: 1 to 3. Valid values:
                /// 
                /// *   contains: contains
                /// *   notContains: does not contain
                /// *   startWith: starts with a prefix
                /// *   endWith: ends with a suffix
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The name of the field based on which instances are filtered. Valid values of N: 1 to 3.
                /// 
                /// Only hostnames are supported. Example: hostName.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value to be matched with the specified field. Valid values of N: 1 to 3.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The mode for creating the alert rule. Valid values:
        /// 
        /// *   true: creates asynchronously
        /// *   false (default): creates synchronously
        /// </summary>
        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
