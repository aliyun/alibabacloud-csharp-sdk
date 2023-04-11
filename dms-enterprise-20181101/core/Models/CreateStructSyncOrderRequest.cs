// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStructSyncOrderRequest : TeaModel {
        /// <summary>
        /// The key of an attachment that is returned after the attachment is uploaded. You can call the [GetUserUploadFileJob](~~206069~~) operation to query the key of the attachment.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The remarks of the ticket.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateStructSyncOrderRequestParam Param { get; set; }
        public class CreateStructSyncOrderRequestParam : TeaModel {
            /// <summary>
            /// Specifies whether to skip an error that occurs in executing an SQL statement. Valid values:
            /// 
            /// *   **true**: continues to execute subsequent SQL statements if an error occurs in executing an SQL statement.
            /// *   **false**: stops executing subsequent SQL statements if an error occurs in executing an SQL statement.
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// The information about the base database.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamSource Source { get; set; }
            public class CreateStructSyncOrderRequestParamSource : TeaModel {
                /// <summary>
                /// The ID of the database. You can call the [SearchDatabases](~~141876~~) operation to query the ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The name that is used to search for the database. You can call the [SearchDatabases](~~141876~~) operation to query the name of the database.
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// Specifies whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The version number of the schema. The default value is the latest schema version number. For more information, see [Manage schema versions](~~202275~~).
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// The information about the table of which you want to synchronize the schema.
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<CreateStructSyncOrderRequestParamTableInfoList> TableInfoList { get; set; }
            public class CreateStructSyncOrderRequestParamTableInfoList : TeaModel {
                /// <summary>
                /// The name of the source table.
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// The name of the destination table.
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// The information about the database to which you want to synchronize the schema of a table.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamTarget Target { get; set; }
            public class CreateStructSyncOrderRequestParamTarget : TeaModel {
                /// <summary>
                /// The ID of the database. You can call the [SearchDatabases](~~141876~~) operation to query the ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The name that is used to search for the database. You can call the [SearchDatabases](~~141876~~) operation to query the name of the database.
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// Specifies whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The version number. By default, this parameter is left empty.
                /// 
                /// >  If you specify the schema version number of the destination database, Data Management (DMS) only compares the schemas of the two databases.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the stakeholders.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see [Manage DMS tenants](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
