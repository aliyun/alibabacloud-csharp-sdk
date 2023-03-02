// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIProjectConfigRequest : TeaModel {
        /// <summary>
        /// The type of the destinations of the synchronization solutions. This parameter cannot be left empty.
        /// 
        /// Valid values: analyticdb_for_mysql, odps, elasticsearch, holo, mysql, and polardb.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The new default global configuration of synchronization solutions. The value indicates the processing rules of different types of DDL messages. The value must be in the JSON format. Example:
        /// 
        /// {"RENAMECOLUMN":"WARNING","DROPTABLE":"WARNING","CREATETABLE":"WARNING","MODIFYCOLUMN":"WARNING","TRUNCATETABLE":"WARNING","DROPCOLUMN":"WARNING","ADDCOLUMN":"WARNING","RENAMETABLE":"WARNING"}
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
        [NameInMap("ProjectConfig")]
        [Validation(Required=false)]
        public string ProjectConfig { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The type of the sources of the synchronization solutions.
        /// 
        /// Valid values: oracle, mysql, polardb, datahub, drds, and analyticdb_for_mysql.
        /// 
        /// If you do not configure this parameter, DataWorks applies the default global configuration to all sources.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
