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
        public List<DescribeVServerGroupsResponseBodyVServerGroups> VServerGroups { get; set; }
        public class DescribeVServerGroupsResponseBodyVServerGroups : TeaModel {
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

            [NameInMap("VServerGroupName")]
            [Validation(Required=false)]
            public string VServerGroupName { get; set; }

            [NameInMap("AssociatedObjects")]
            [Validation(Required=false)]
            public DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjects AssociatedObjects { get; set; }
            public class DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjects : TeaModel {
                [NameInMap("Listeners")]
                [Validation(Required=false)]
                public List<DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjectsListeners> Listeners { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjectsListeners : TeaModel {
                    public string Protocol { get; set; }
                    public int? Port { get; set; }
                }
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjectsRules> Rules { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsAssociatedObjectsRules : TeaModel {
                    public string Domain { get; set; }
                    public string Url { get; set; }
                    public string RuleName { get; set; }
                    public string RuleId { get; set; }
                }
            };

        }

    }

}
