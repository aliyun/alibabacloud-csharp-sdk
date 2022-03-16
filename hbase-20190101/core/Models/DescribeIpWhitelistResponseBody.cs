// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeIpWhitelistResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public DescribeIpWhitelistResponseBodyGroups Groups { get; set; }
        public class DescribeIpWhitelistResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<DescribeIpWhitelistResponseBodyGroupsGroup> Group { get; set; }
            public class DescribeIpWhitelistResponseBodyGroupsGroup : TeaModel {
                public string GroupName { get; set; }
                public DescribeIpWhitelistResponseBodyGroupsGroupIpList IpList { get; set; }
                public class DescribeIpWhitelistResponseBodyGroupsGroupIpList : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }
                public int? IpVersion { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
