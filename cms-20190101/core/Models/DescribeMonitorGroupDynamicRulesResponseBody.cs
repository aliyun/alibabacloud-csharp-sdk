// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupDynamicRulesResponseBody : TeaModel {
        /// <summary>
        /// The responses code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that are associated with the application group.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMonitorGroupDynamicRulesResponseBodyResource Resource { get; set; }
        public class DescribeMonitorGroupDynamicRulesResponseBodyResource : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResource> Resource { get; set; }
            public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResource : TeaModel {
                /// <summary>
                /// The type of the cloud service to which the dynamic rule belongs. Valid values:
                /// 
                /// *   ecs: Elastic Compute Service (ECS)
                /// *   rds: ApsaraDB RDS
                /// *   slb: Server Load Balancer (SLB)
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The filter condition. Valid values:
                /// 
                /// *   and: queries the instances that meet all alert rules.
                /// *   or: queries the instances that meet any alert rule.
                /// </summary>
                [NameInMap("FilterRelation")]
                [Validation(Required=false)]
                public string FilterRelation { get; set; }

                /// <summary>
                /// The dynamic rules of the application group.
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters Filters { get; set; }
                public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters : TeaModel {
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter> Filter { get; set; }
                    public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter : TeaModel {
                        /// <summary>
                        /// The method that is used to filter the instances. Valid values:
                        /// 
                        /// *   contains: contains
                        /// *   startWith: starts with a prefix
                        /// *   endWith: ends with a suffix
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// The instance name.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The value of the dynamic rule.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
