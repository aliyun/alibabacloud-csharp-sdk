// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationSummaryResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails. You can locate the error based on the request ID.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMigrationSummaryResponseBodyData Data { get; set; }
        public class GetMigrationSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the migration task was modified.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The ID of the DataWorks workspace.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The name of the migration task.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the migration task was created.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The details of the migration task.
            /// </summary>
            [NameInMap("MigrationId")]
            [Validation(Required=false)]
            public long? MigrationId { get; set; }

            /// <summary>
            /// The ID of the migration task.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the user who creates the migration task.
            /// </summary>
            [NameInMap("OpUser")]
            [Validation(Required=false)]
            public string OpUser { get; set; }

            /// <summary>
            /// The status of the migration task. Valid values:
            /// 
            /// *   INIT: The migration task is initiating.
            /// *   EDITING: The migration task is being edited.
            /// *   IMPORTING: The migration task is importing data objects.
            /// *   IMPORT_ERROR: The migration task fails to import data objects.
            /// *   IMPORT_SUCCESS: Data objects are imported.
            /// *   EXPORTING: The migration task is exporting data objects.
            /// *   EXPORT_ERROR: The migration task fails to export data objects.
            /// *   EXPORT_SUCCESS: The migration task successfully exports data objects.
            /// *   REVOKED: The migration task is canceled.
            /// *   PARTIAL_SUCCESS: The migration task successfully imports or exports only some data objects.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The ID of the user who manages the migration task.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the migration task.
        /// 
        /// You can call the [CreateImportMigration](~~CreateImportMigration~~) operation to obtain the ID of the import task and call the [CreateExportMigration](~~CreateImportMigration~~) operation to obtain the ID of the export task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
