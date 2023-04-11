// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDDLPublishRecordsRequest : TeaModel {
        /// <summary>
        /// The ID of the ticket.
        /// 
        /// > You can create a schema design ticket in the Data Management (DMS) console. For more information, see [Design schemas](~~69711~~). You can also call the [CreateOrder](~~144649~~) operation to create a schema design ticket and obtain the ID of the ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, log on to the DMS console and move the pointer over the profile picture in the upper-right corner. For more information, see [Manage DMS tenants](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
