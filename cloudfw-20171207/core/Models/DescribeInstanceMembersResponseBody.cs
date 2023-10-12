// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersResponseBody : TeaModel {
        /// <summary>
        /// The information about the member.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DescribeInstanceMembersResponseBodyMembers> Members { get; set; }
        public class DescribeInstanceMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// The time when the member was added to Cloud Firewall. The value is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// The remarks of the member.
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// The name of the member.
            /// </summary>
            [NameInMap("MemberDisplayName")]
            [Validation(Required=false)]
            public string MemberDisplayName { get; set; }

            /// <summary>
            /// The status of the member. Valid values:
            /// 
            /// *   **normal**
            /// *   **deleting**
            /// </summary>
            [NameInMap("MemberStatus")]
            [Validation(Required=false)]
            public string MemberStatus { get; set; }

            /// <summary>
            /// The UID of the member.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// The time when the member was last modified. The value is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public int? ModifyTime { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInstanceMembersResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInstanceMembersResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of the members.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
