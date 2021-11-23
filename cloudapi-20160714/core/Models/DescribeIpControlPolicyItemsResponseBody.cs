// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlPolicyItemsResponseBody : TeaModel {
        [NameInMap("IpControlPolicyItems")]
        [Validation(Required=false)]
        public DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems IpControlPolicyItems { get; set; }
        public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems : TeaModel {
            [NameInMap("IpControlPolicyItem")]
            [Validation(Required=false)]
            public List<DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem> IpControlPolicyItem { get; set; }
            public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem : TeaModel {
                public string AppId { get; set; }
                public string CidrIp { get; set; }
                public string CreateTime { get; set; }
                public string ModifiedTime { get; set; }
                public string PolicyItemId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
