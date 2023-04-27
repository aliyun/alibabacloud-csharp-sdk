// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateFreeLockCorrectOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](~~206069~~) operation to obtain the attachment key from the value of the AttachmentKey parameter.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The stakeholders of the data change. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The key of the attachment that contains the SQL statements used to roll back the data change.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string ParamShrink { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserListShrink { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
