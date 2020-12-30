// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeIpWhitelistGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public DescribeIpWhitelistGroupsResponseBodyGroups Groups { get; set; }
        public class DescribeIpWhitelistGroupsResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<DescribeIpWhitelistGroupsResponseBodyGroupsGroup> Group { get; set; }
            public class DescribeIpWhitelistGroupsResponseBodyGroupsGroup : TeaModel {
                public int? IpVersion { get; set; }
                public string GroupName { get; set; }
                public DescribeIpWhitelistGroupsResponseBodyGroupsGroupIpList IpList { get; set; }
                public class DescribeIpWhitelistGroupsResponseBodyGroupsGroupIpList : TeaModel {
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public List<string> IP { get; set; }

                }
            }
        };

    }

}
