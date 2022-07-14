// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListResponseBody : TeaModel {
        [NameInMap("AclGroupList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAclGroupListResponseBodyAclGroupList> AclGroupList { get; set; }
        public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupList : TeaModel {
            [NameInMap("AclGroupId")]
            [Validation(Required=false)]
            public string AclGroupId { get; set; }

            [NameInMap("AclGroupName")]
            [Validation(Required=false)]
            public string AclGroupName { get; set; }

            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
