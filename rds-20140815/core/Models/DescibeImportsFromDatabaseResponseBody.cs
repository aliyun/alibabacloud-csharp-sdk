// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescibeImportsFromDatabaseResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of migration tasks.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescibeImportsFromDatabaseResponseBodyItems Items { get; set; }
        public class DescibeImportsFromDatabaseResponseBodyItems : TeaModel {
            [NameInMap("ImportResultFromDB")]
            [Validation(Required=false)]
            public List<DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB> ImportResultFromDB { get; set; }
            public class DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB : TeaModel {
                /// <summary>
                /// The status of the migration task. Valid values:
                /// 
                /// *   **NotStart**: The migration task has not started.
                /// *   **FullExporting**: The migration task is exporting full data.
                /// *   **FullImporting**: The migration task is importing full data.
                /// *   **Success**: The migration task is successful.
                /// *   **Failed**: The migration task fails.
                /// *   **Canceled**: The migration task is canceled.
                /// *   **Canceling**: The migration task is being canceled.
                /// *   **IncrementalWaiting**: The migration task is waiting to synchronize incremental data.
                /// *   **IncrementalImporting**: The migration task is synchronizing incremental data.
                /// *   **StopSyncing**: The migration task stops synchronizing data.
                /// </summary>
                [NameInMap("ImportDataStatus")]
                [Validation(Required=false)]
                public string ImportDataStatus { get; set; }

                /// <summary>
                /// The description of the migration task.
                /// </summary>
                [NameInMap("ImportDataStatusDescription")]
                [Validation(Required=false)]
                public string ImportDataStatusDescription { get; set; }

                /// <summary>
                /// The type of the migration task. Valid values:
                /// 
                /// *   **Full**: full migration
                /// *   **Incremental:**: incremental migration
                /// </summary>
                [NameInMap("ImportDataType")]
                [Validation(Required=false)]
                public string ImportDataType { get; set; }

                /// <summary>
                /// The ID of the migration task.
                /// </summary>
                [NameInMap("ImportId")]
                [Validation(Required=false)]
                public int? ImportId { get; set; }

                /// <summary>
                /// The time when the migration task synchronized incremental data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("IncrementalImportingTime")]
                [Validation(Required=false)]
                public string IncrementalImportingTime { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
