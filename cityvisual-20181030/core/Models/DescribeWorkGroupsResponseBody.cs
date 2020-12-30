// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeWorkGroupsResponseBody : TeaModel {
        [NameInMap("WorkGroups")]
        [Validation(Required=false)]
        public DescribeWorkGroupsResponseBodyWorkGroups WorkGroups { get; set; }
        public class DescribeWorkGroupsResponseBodyWorkGroups : TeaModel {
            [NameInMap("WorkGroup")]
            [Validation(Required=false)]
            public List<DescribeWorkGroupsResponseBodyWorkGroupsWorkGroup> WorkGroup { get; set; }
            public class DescribeWorkGroupsResponseBodyWorkGroupsWorkGroup : TeaModel {
                public string UpdateTime { get; set; }
                public string Description { get; set; }
                public string Protocol { get; set; }
                public string CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string TheoryCutStatus { get; set; }
                public string WorkGroupId { get; set; }
                public string WorkGroupName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
