// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyInstanceMemberAttributesRequest : TeaModel {
        /// <summary>
        /// The members that to be modified.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ModifyInstanceMemberAttributesRequestMembers> Members { get; set; }
        public class ModifyInstanceMemberAttributesRequestMembers : TeaModel {
            /// <summary>
            /// The remarks of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// The UID of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

        }

    }

}
