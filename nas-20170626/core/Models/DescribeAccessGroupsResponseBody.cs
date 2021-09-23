// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AccessGroups")]
        [Validation(Required=false)]
        public DescribeAccessGroupsResponseBodyAccessGroups AccessGroups { get; set; }
        public class DescribeAccessGroupsResponseBodyAccessGroups : TeaModel {
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public List<DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup> AccessGroup { get; set; }
            public class DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup : TeaModel {
                public string AccessGroupName { get; set; }
                public string Description { get; set; }
                public string AccessGroupType { get; set; }
                public int? RuleCount { get; set; }
                public int? MountTargetCount { get; set; }
            }
        };

    }

}
