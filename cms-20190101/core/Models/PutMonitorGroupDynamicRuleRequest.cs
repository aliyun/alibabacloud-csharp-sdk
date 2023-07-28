// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitorGroupDynamicRuleRequest : TeaModel {
        /// <summary>
        /// The method that is used to filter instances. Valid values of N: 1 to 3. Valid values:
        /// 
        /// *   contains: contains
        /// *   notContains: excludes
        /// *   startWith: starts with a prefix
        /// *   endWith: ends with a suffix
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupRules")]
        [Validation(Required=false)]
        public List<PutMonitorGroupDynamicRuleRequestGroupRules> GroupRules { get; set; }
        public class PutMonitorGroupDynamicRuleRequestGroupRules : TeaModel {
            /// <summary>
            /// The logical operator used between conditional expressions in the alert rule. Valid values of N: 1 to 3. Valid values:
            /// 
            /// *   and: The instances that meet all the conditional expressions are automatically added to the application group.
            /// *   or: The instances that meet one of the conditional expressions are automatically added to the application group.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The mode for creating the alert rule. Valid values:
            /// 
            /// *   true: creates asynchronously
            /// *   false (default value): creates synchronously
            /// </summary>
            [NameInMap("FilterRelation")]
            [Validation(Required=false)]
            public string FilterRelation { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<PutMonitorGroupDynamicRuleRequestGroupRulesFilters> Filters { get; set; }
            public class PutMonitorGroupDynamicRuleRequestGroupRulesFilters : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The operation that you want to perform. Set the value to **PutMonitorGroupDynamicRule**.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The HTTP status code.
                /// 
                /// >  The status code 200 indicates that the call was successful.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
