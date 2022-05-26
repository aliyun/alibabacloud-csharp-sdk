// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
