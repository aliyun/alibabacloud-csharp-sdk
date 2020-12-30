// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
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

        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyNode Node { get; set; }
        public class DescribeRoleZoneInfoResponseBodyNode : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyNodeNodeInfo> NodeInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyNodeNodeInfo : TeaModel {
                public string CurrentMinorVersion { get; set; }
                public int? InsType { get; set; }
                public int? IsLatestVersion { get; set; }
                public string InsName { get; set; }
                public string NodeType { get; set; }
                public string ZoneId { get; set; }
                public string Role { get; set; }
                public string CustinsId { get; set; }
                public string NodeId { get; set; }
            }
        };

    }

}
