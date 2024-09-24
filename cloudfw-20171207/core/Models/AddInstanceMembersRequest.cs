// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddInstanceMembersRequest : TeaModel {
        /// <summary>
        /// <para>The members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddInstanceMembersRequestMembers> Members { get; set; }
        public class AddInstanceMembersRequestMembers : TeaModel {
            /// <summary>
            /// <para>The remarks of the member. The value must be 1 to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>renewal</para>
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// <para>The UID of the member. You can add up to 20 members to Cloud Firewall at a time.</para>
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
