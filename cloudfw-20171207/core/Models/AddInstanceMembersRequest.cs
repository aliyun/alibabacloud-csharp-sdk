// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddInstanceMembersRequest : TeaModel {
        /// <summary>
        /// The members that you want to add to Cloud Firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddInstanceMembersRequestMembers> Members { get; set; }
        public class AddInstanceMembersRequestMembers : TeaModel {
            /// <summary>
            /// The remarks of member that you want to add to Cloud Firewall. The remarks must be 1 to 256 characters in length.
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// The UID of member that you want to add to Cloud Firewall.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

        }

    }

}
