// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationSummaryResponseBody : TeaModel {
        /// <summary>
        /// The details of the migration task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMigrationSummaryResponseBodyData Data { get; set; }
        public class GetMigrationSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the user who created the task.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The URL that is used to download the package of the export task. You can use the URL to download the package of the export task.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the task was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("MigrationId")]
            [Validation(Required=false)]
            public long? MigrationId { get; set; }

            /// <summary>
            /// The task name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the user who managed the task.
            /// </summary>
            [NameInMap("OpUser")]
            [Validation(Required=false)]
            public string OpUser { get; set; }

            /// <summary>
            /// The ID of the DataWorks workspace to which the migration task belongs.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The status of the migration task. Valid values:
            /// 
            /// *   INIT
            /// *   EDITING
            /// *   IMPORTING
            /// *   IMPORT_ERROR
            /// *   IMPORT_SUCCESS
            /// *   EXPORTING
            /// *   EXPORT_ERROR
            /// *   EXPORT_SUCCESS
            /// *   REVOKED
            /// *   PARTIAL_SUCCESS
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the request ID to query logs and troubleshoot issues.
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
