// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIProjectConfigResponseBody : TeaModel {
        /// <summary>
        /// The information about the query operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDIProjectConfigResponseBodyData Data { get; set; }
        public class ListDIProjectConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The default global configuration of sync solutions. The value indicates the processing rules of different types of DDL messages. Example:
            /// 
            /// {"RENAMECOLUMN":"WARNING","DROPTABLE":"WARNING","CREATETABLE":"WARNING","MODIFYCOLUMN":"WARNING","TRUNCATETABLE":"WARNING","DROPCOLUMN":"WARNING","ADDCOLUMN":"WARNING","RENAMETABLE":"WARNING"}
            /// 
            /// Field description:
            /// 
            /// *   RENAMECOLUMN: renames the column.
            /// *   DROPTABLE: deletes the table.
            /// *   CREATETABLE: creates a table.
            /// *   MODIFYCOLUMN: changes the column data type.
            /// *   TRUNCATETABLE: clears the table.
            /// *   DROPCOLUMN: deletes the column.
            /// *   ADDCOLUMN: creates a column.
            /// *   RENAMETABLE: renames the table.
            /// 
            /// DataWorks processes a DDL message of a specific type based on the following policies after it receives the message:
            /// 
            /// *   WARNING: ignores the message and records an alert in real-time sync logs. The alert contains information about the situation that the message is ignored because of an execution error.
            /// *   IGNORE: discards the message and does not send it to the destination data source.
            /// *   CRITICAL: terminates the real-time sync node and sets the node status to Failed.
            /// *   NORMAL: sends the message to the destination data source to process the message. Each destination data source may process DDL messages based on its own business logic. If DataWorks adopts the NORMAL policy, DataWorks only forwards DDL messages.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
