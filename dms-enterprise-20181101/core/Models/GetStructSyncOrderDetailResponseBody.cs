// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the schema synchronization ticket.
        /// </summary>
        [NameInMap("StructSyncOrderDetail")]
        [Validation(Required=false)]
        public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail StructSyncOrderDetail { get; set; }
        public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail : TeaModel {
            /// <summary>
            /// Indicates whether to skip errors. Valid values:
            /// 
            /// *   **true**: skips the error and continues to execute SQL statements.
            /// *   **false**: stops executing SQL statements.
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// The information about the source database.
            /// </summary>
            [NameInMap("SourceDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo SourceDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo : TeaModel {
                /// <summary>
                /// The ID of the source database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of the environment to which the database instance belongs. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The schema version of the source database. Valid values:
            /// 
            /// *   **DATASOURCE**: the default latest version of the system
            /// *   **VERSION**: a previous schema version that you manually specify
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The version information about the source instance.
            /// 
            /// > This parameter is displayed only when the value of the **SourceType** parameter is **VERSION**.
            /// </summary>
            [NameInMap("SourceVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo SourceVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo : TeaModel {
                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// The information about the table whose schema you want to synchronize.
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList> TableInfoList { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList : TeaModel {
                /// <summary>
                /// The name of the table whose schema you want to synchronize.
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// The name of the table to which you want to synchronize the schema of a table.
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// The information about the destination database.
            /// </summary>
            [NameInMap("TargetDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo TargetDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo : TeaModel {
                /// <summary>
                /// The ID of the destination database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of the environment to which the database instance belongs. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The schema version of the destination database. Valid values:
            /// 
            /// *   **DATASOURCE**: the default latest version of the system
            /// *   **VERSION**: a previous schema version that you manually specify
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The version information about the destination instance.
            /// 
            /// > This parameter is displayed only when the value of the **SourceType** parameter is **VERSION**.
            /// </summary>
            [NameInMap("TargetVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo TargetVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo : TeaModel {
                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
