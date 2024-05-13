// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataImportOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to obtain the attachment key from the value of the AttachmentKey parameter.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The purpose or objective of the data import. This parameter is used to help reduce unnecessary communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataImportOrderRequestParam Param { get; set; }
        public class CreateDataImportOrderRequestParam : TeaModel {
            /// <summary>
            /// The key of the attachment that contains the SQL statements used to import data. You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to the attachment key from the value of the AttachmentKey parameter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// The reason for the data import.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The type of the CSV file. Valid values:
            /// 
            /// *   **true**: The first row in the CSV file contains field names.
            /// *   **false**: The first row in the CSV file contains data.
            /// 
            /// >  This parameter is required if you set the **FileType** parameter to **CSV**.
            /// </summary>
            [NameInMap("CsvFirstRowIsColumnDef")]
            [Validation(Required=false)]
            public bool? CsvFirstRowIsColumnDef { get; set; }

            /// <summary>
            /// The database to which you want to import data. You can specify only one database.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataImportOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataImportOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// The ID of the database. The database can be a physical database or a logical database.
                /// 
                /// *   To obtain the ID of a physical database, call the [ListDatabases](https://help.aliyun.com/document_detail/141873.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation.
                /// *   To obtain the ID of a logical database, call the [ListLogicDatabases](https://help.aliyun.com/document_detail/141874.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// Specifies whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is a physical database.
                /// 
                /// >  If you set this parameter to **true**, the database that you specify must be a logical database.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// The encoding algorithm to be used by the destination database. Valid values:
            /// 
            /// *   **AUTO**: automatic identification
            /// *   **UTF-8**: UTF-8 encoding
            /// *   **GBK**: GBK encoding
            /// *   **ISO-8859-1**: ISO-8859-1 encoding
            /// </summary>
            [NameInMap("FileEncoding")]
            [Validation(Required=false)]
            public string FileEncoding { get; set; }

            /// <summary>
            /// The format of the file for the data import. Valid values:
            /// 
            /// *   **SQL**: an SQL file
            /// *   **CSV**: a CSV file
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// Specifies whether to skip an error that occurs. Valid values:
            /// 
            /// *   **true**: skips the error and continues to execute SQL statements.
            /// *   **false**: stops executing SQL statements.
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// The import mode. Valid values:
            /// 
            /// *   **FAST_MODE**: In the Execute step, the uploaded file is read and SQL statements are executed to import data to the specified destination database. Compared with the security mode, this mode can be used to import data in a less secure but more efficient manner.
            /// *   **SAFE_MODE**: In the Precheck step, the uploaded file is parsed, and SQL statements or CSV file data is cached. In the Execute step, the cached SQL statements are read and executed to import data, or the cached CSV file data is read and imported to the specified destination database. This mode can be used to import data in a more secure but less efficient manner.
            /// </summary>
            [NameInMap("ImportMode")]
            [Validation(Required=false)]
            public string ImportMode { get; set; }

            /// <summary>
            /// The mode in which the data in the CSV format is to be written to the destination table. Valid values:
            /// 
            /// *   **INSERT**: The database checks the primary key when data is written. If a duplicate primary key value exists, an error message is returned.
            /// *   **INSERT_IGNORE**: If the imported data contains data records that are the same as those in the destination table, the new data records are ignored.
            /// *   **REPLACE_INTO**: If the imported data contains a row that has the same value for the primary key or unique index as one row in the destination table, the database deletes the existing row and inserts the new row into the destination table.
            /// 
            /// >  This parameter is required if you set the **FileType** parameter to **CSV**.
            /// </summary>
            [NameInMap("InsertType")]
            [Validation(Required=false)]
            public string InsertType { get; set; }

            /// <summary>
            /// The key of the attachment that contains the SQL statements used to roll back the data import. You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to obtain the attachment key from the value of the AttachmentKey parameter.
            /// 
            /// >  This parameter is required if you set the **RollbackSqlType** parameter to **ATTACHMENT**.
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// The SQL statements used to roll back the data import.
            /// 
            /// >  This parameter is required if you set the **RollbackSqlType** parameter to **TEXT**.
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// The format of the SQL statements used to roll back the data import. Valid values:
            /// 
            /// *   **TEXT**: text
            /// *   **ATTACHMENT**: attachment
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

            /// <summary>
            /// The destination table to which you want to import the data in the CSV format.
            /// 
            /// >  This parameter is required if you set the **FileType** parameter to **CSV**.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The stakeholders of the data import. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
