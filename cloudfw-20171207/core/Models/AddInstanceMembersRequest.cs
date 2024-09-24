// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddInstanceMembersRequest : TeaModel {
        /// <summary>
        /// The members.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddInstanceMembersRequestMembers> Members { get; set; }
        public class AddInstanceMembersRequestMembers : TeaModel {
            /// <summary>
            /// The remarks of the member. The value must be 1 to 256 characters in length.
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// The UID of the member. You can add up to 20 members to Cloud Firewall at a time.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

        }

    }

}
