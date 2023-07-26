// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DisassociateMembersResponseBody : TeaModel {
        /// <summary>
        /// The time when the contact was unbound from the object.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DisassociateMembersResponseBodyMembers> Members { get; set; }
        public class DisassociateMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// The ID of the object. Valid values:
            /// 
            /// - ID of the resource directory
            /// - ID of the folder
            /// - ID of the member
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// The time when the contact was unbound from the object.
            /// </summary>
            [NameInMap("ModifyDate")]
            [Validation(Required=false)]
            public string ModifyDate { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
