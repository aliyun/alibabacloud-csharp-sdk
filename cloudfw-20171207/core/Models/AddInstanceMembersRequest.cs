// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddInstanceMembersRequest : TeaModel {
        /// <summary>
        /// <para>The list of Cloud Firewall member accounts to add. Call DescribeInstanceRdAccounts to obtain the available MemberUid values. You can add up to 20 members at a time, subject to the instance member quota.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddInstanceMembers</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddInstanceMembersRequestMembers> Members { get; set; }
        public class AddInstanceMembersRequestMembers : TeaModel {
            /// <summary>
            /// <para>The description of the Cloud Firewall member account. The description must be 1 to 256 characters in length. You can add up to 20 member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>renewal</para>
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// <para>The UID of the Cloud Firewall member account. You can add up to 20 member accounts.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

        }

    }

}
