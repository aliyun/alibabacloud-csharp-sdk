// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersResponseBody : TeaModel {
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DescribeInstanceMembersResponseBodyMembers> Members { get; set; }
        public class DescribeInstanceMembersResponseBodyMembers : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            [NameInMap("MemberDisplayName")]
            [Validation(Required=false)]
            public string MemberDisplayName { get; set; }

            [NameInMap("MemberStatus")]
            [Validation(Required=false)]
            public string MemberStatus { get; set; }

            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public int? ModifyTime { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInstanceMembersResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInstanceMembersResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
