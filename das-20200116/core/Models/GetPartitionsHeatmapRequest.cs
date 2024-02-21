// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPartitionsHeatmapRequest : TeaModel {
        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The time range to be queried. Valid values:
        /// 
        /// *   **LAST_ONE_HOURS**: the last hour.
        /// *   **LAST_SIX_HOURS**: the last six hours.
        /// *   **LAST_ONE_DAYS**: the last day.
        /// *   **LAST_THREE_DAYS**: the last three days.
        /// *   **LAST_SEVEN_DAYS**: the last seven days.
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

        /// <summary>
        /// The type of the data to be queried. Valid values:
        /// 
        /// *   **READ_ROWS**: the read rows.
        /// *   **WRITTEN_ROWS**: the written rows.
        /// *   **READ_WRITTEN_ROWS**: the read and written rows.
        /// *   **UPDATE_ROWS**: the updated rows.
        /// *   **INSERTED_ROWS**: the inserted rows.
        /// *   **DELETED_ROWS**: the deleted rows.
        /// *   **READ_ROWS_WITH_DN**: the read rows returned from a data node.
        /// *   **WRITTEN_ROWS_WITH_DN**: the written rows returned from a data node.
        /// *   **READ_WRITTEN_ROWS_WITH_DN**: the read and written rows returned from a data node.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
