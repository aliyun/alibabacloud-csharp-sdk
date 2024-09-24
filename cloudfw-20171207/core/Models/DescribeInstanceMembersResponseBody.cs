// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the member.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DescribeInstanceMembersResponseBodyMembers> Members { get; set; }
        public class DescribeInstanceMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>The time when the member was added to Cloud Firewall. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615189819</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <para>The remarks of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>renewal</para>
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// <para>The name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudfirewall_2</para>
            /// </summary>
            [NameInMap("MemberDisplayName")]
            [Validation(Required=false)]
            public string MemberDisplayName { get; set; }

            /// <summary>
            /// <para>The status of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b></description></item>
            /// <item><description><b>deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("MemberStatus")]
            [Validation(Required=false)]
            public string MemberStatus { get; set; }

            /// <summary>
            /// <para>The UID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The time when the member was last modified. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615189819</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public int? ModifyTime { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInstanceMembersResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInstanceMembersResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of the members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A531AE1A-FBA2-48B6-BAB8-84D02BD409EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
