// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCorrectOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a logical database.
        /// *   **false**: The database is a physical database.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The databases in which you want to change data.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string ParamShrink { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserListShrink { get; set; }

        /// <summary>
        /// The estimated number of data rows to be affected by the data change.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
