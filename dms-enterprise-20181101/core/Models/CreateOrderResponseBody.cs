// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateOrderResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("CreateOrderResult")]
        [Validation(Required=false)]
        public CreateOrderResponseBodyCreateOrderResult CreateOrderResult { get; set; }
        public class CreateOrderResponseBodyCreateOrderResult : TeaModel {
            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public List<long?> OrderIds { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// ## PluginParam parameter
        /// 
        /// ```
        /// 
        /// # Change a schema design.
        ///  {
        ///     "title": "test", // The name of the ticket.
        ///     "description": "test", // The description of the ticket.
        ///     "dbId": 11****, // The database to which changes are made.
        ///     "logic": false, // Specifies whether the database is a logical database.
        ///     "relatedIds": [], // The IDs of the stakeholders that are involved in the ticket.
        ///   }
        /// 
        /// # Export data.
        ///  {
        ///   "classify": "Reason", // The purpose of the ticket.
        ///   "dbId": 17****, // The ID of the database from which data is exported.
        ///   "exeSQL": "select 1", // The SQL statement that is executed to export data.
        ///   "logic": false, // Specifies whether the database is a logical database.
        ///   "ignoreAffectRows": false, // Specifies whether to ignore the affected rows.
        ///   "affectRows": 1, // The estimated number of affected rows.
        ///   "ignoreAffectRowsReason": "" // The reason for ignoring the affected rows.
        ///  }
        /// 
        /// If you need to create more types of tickets, submit a ticket for consultation. 
        /// ```
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
