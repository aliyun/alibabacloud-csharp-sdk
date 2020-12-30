// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeVServerGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public DescribeVServerGroupsResponseBodyVServerGroups VServerGroups { get; set; }
        public class DescribeVServerGroupsResponseBodyVServerGroups : TeaModel {
            [NameInMap("VServerGroup")]
            [Validation(Required=false)]
            public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup> VServerGroup { get; set; }
            public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup : TeaModel {
                public string VServerGroupId { get; set; }
                public string VServerGroupName { get; set; }
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects : TeaModel {
                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners Listeners { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener> Listener { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener : TeaModel {
                            public string Protocol { get; set; }
                            public int? Port { get; set; }
                        }
                    };

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules Rules { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules : TeaModel {
                        [NameInMap("Rule")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule> Rule { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule : TeaModel {
                            public string Domain { get; set; }
                            public string Url { get; set; }
                            public string RuleName { get; set; }
                            public string RuleId { get; set; }
                        }
                    };

                }
            }
        };

    }

}
