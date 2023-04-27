// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCronClearOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// Indicates whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a logical database.
        /// *   **false**: The database is not a logical database.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The databases for which you want to clear historical data.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string ParamShrink { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  The ID of the tenant is displayed when you move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the [View information about the current tenant](~~181330~~) section of the Manage DMS tenants topic.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserListShrink { get; set; }

        /// <summary>
        /// The reason for the data change.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
