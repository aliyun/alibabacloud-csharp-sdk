// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataCorrectRequest : TeaModel {
        /// <summary>
        /// The parameters that are required to perform the data change.
        /// 
        /// ```
        /// 
        /// json
        /// "actionDetail" : {
        ///     "startTime" :"2021-07-01 00:00:00", // Specify the start time to change data. If you want to immediately change data, you do not need to set this parameter. 
        ///     "endTime" : "2021-07-01 01:00:00", // Specify the end time to change data. If you want to immediately change data, you do not need to set this parameter. 
        ///     "transaction" : false, // Specify whether to change data as a transaction. 
        ///     "backupData" : true // Specify whether to back up data. 
        ///   }
        /// ```
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> ActionDetail { get; set; }

        /// <summary>
        /// The ID of the ticket. You can call the [ListOrders](~~144643~~) operation to query the ID of the ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public string Tid { get; set; }

    }

}
