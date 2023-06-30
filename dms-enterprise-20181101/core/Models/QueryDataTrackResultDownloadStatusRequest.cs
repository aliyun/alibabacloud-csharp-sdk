// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class QueryDataTrackResultDownloadStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the download key, which is used to identify the parsing progress of data tracking logs. You can call the DownloadDataTrackResult operation to query the ID of the key.
        /// </summary>
        [NameInMap("DownloadKeyId")]
        [Validation(Required=false)]
        public string DownloadKeyId { get; set; }

        /// <summary>
        /// The ID of the ticket. You can call the [ListOrders](~~144643~~) operation to query the ID of the ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
