// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DisassociateMembersRequest : TeaModel {
        /// <summary>
        /// The ID of the contact.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// The IDs of objects from which you want to unbind the contact.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<string> Members { get; set; }

    }

}
