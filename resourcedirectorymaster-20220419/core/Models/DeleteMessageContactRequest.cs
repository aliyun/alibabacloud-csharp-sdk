// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeleteMessageContactRequest : TeaModel {
        /// <summary>
        /// The ID of the contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// Specifies whether to retain the contact for members. Valid values:
        /// 
        /// *   true (default): retains the contact for members. In this case, the contact can still receive messages for the members.
        /// *   false: does not retain the contact for members. In this case, the contact can no longer receive messages for the members. If you set this parameter to false, the response is asynchronously returned. You can call [GetMessageContactDeletionStatus](~~GetMessageContactDeletionStatus~~) to obtain the deletion result.
        /// </summary>
        [NameInMap("RetainContactInMembers")]
        [Validation(Required=false)]
        public bool? RetainContactInMembers { get; set; }

    }

}
