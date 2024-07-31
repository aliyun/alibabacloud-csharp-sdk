// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIProjectConfigResponseBody : TeaModel {
        /// <summary>
        /// The information about the query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDIProjectConfigResponseBodyData Data { get; set; }
        public class ListDIProjectConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The default global configuration of synchronization solutions. The value indicates the processing rules of different types of DDL messages. Example: {"RENAMECOLUMN":"WARNING","DROPTABLE":"WARNING","CREATETABLE":"WARNING","MODIFYCOLUMN":"WARNING","TRUNCATETABLE":"WARNING","DROPCOLUMN":"WARNING","ADDCOLUMN":"WARNING","RENAMETABLE":"WARNING"}
            /// 
            /// Field description:
            /// 
            /// *   RENAMECOLUMN: renames a column.
            /// *   DROPTABLE: deletes a table.
            /// *   CREATETABLE: creates a table.
            /// *   MODIFYCOLUMN: changes the data type of a column.
            /// *   TRUNCATETABLE: clears a table.
            /// *   DROPCOLUMN: deletes a column.
            /// *   ADDCOLUMN: creates a column.
            /// *   RENAMETABLE: renames a table.
            /// 
            /// DataWorks processes a DDL message of a specific type based on the following rules:
            /// 
            /// *   WARNING: ignores the message and records an alert in real-time synchronization logs. The alert contains information about the situation that the message is ignored because of an execution error.
            /// *   IGNORE: discards the message and does not send it to the destination.
            /// *   CRITICAL: terminates the real-time synchronization node and sets the node status to Failed.
            /// *   NORMAL: sends the message to the destination to process the message. Each destination processes DDL messages based on its own business logic. If DataWorks adopts the NORMAL policy, DataWorks only forwards DDL messages.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
