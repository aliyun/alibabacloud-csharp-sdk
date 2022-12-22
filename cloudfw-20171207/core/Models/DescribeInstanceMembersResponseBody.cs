// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersResponseBody : TeaModel {
        /// <summary>
        /// The information about the member in Cloud Firewall.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DescribeInstanceMembersResponseBodyMembers> Members { get; set; }
        public class DescribeInstanceMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// The time when the member was added to Cloud Firewall.
            /// 
            /// >  The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// The remarks of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// The name of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberDisplayName")]
            [Validation(Required=false)]
            public string MemberDisplayName { get; set; }

            /// <summary>
            /// The status of the member in Cloud Firewall. Valid values:
            /// 
            /// *   **normal**
            /// *   **deleting**
            /// </summary>
            [NameInMap("MemberStatus")]
            [Validation(Required=false)]
            public string MemberStatus { get; set; }

            /// <summary>
            /// The UID of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// The time when the member in Cloud Firewall was last modified.
            /// 
            /// >  The value is a UNIX timestamp. Unit: seconds.
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
            /// The page number of the current page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of the members in Cloud Firewall.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
