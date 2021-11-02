// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllGroupsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeAllGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeAllGroupsResponseBodyGroups : TeaModel {
            [NameInMap("GroupFlag")]
            [Validation(Required=false)]
            public int? GroupFlag { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
