// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataImportOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment that provides more instructions for the ticket. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key from the value of the AttachmentKey parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The purpose or objective of the data import. This parameter is used to help reduce unnecessary communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataImportOrderRequestParam Param { get; set; }
        public class CreateDataImportOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The key of the attachment that contains the SQL statements used to import data. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to the attachment key from the value of the AttachmentKey parameter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order_text</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The reason for the data import.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The type of the CSV file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The first row in the CSV file contains field names.</description></item>
            /// <item><description><b>false</b>: The first row in the CSV file contains data.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>FileType</b> parameter to <b>CSV</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CsvFirstRowIsColumnDef")]
            [Validation(Required=false)]
            public bool? CsvFirstRowIsColumnDef { get; set; }

            /// <summary>
            /// <para>The database to which you want to import data. You can specify only one database.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataImportOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataImportOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// <para>The ID of the database. The database can be a physical database or a logical database.</para>
                /// <list type="bullet">
                /// <item><description>To obtain the ID of a physical database, call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// <item><description>To obtain the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1860****</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>Specifies whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is a physical database.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If you set this parameter to <b>true</b>, the database that you specify must be a logical database.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// <para>The encoding algorithm to be used by the destination database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUTO</b>: automatic identification</description></item>
            /// <item><description><b>UTF-8</b>: UTF-8 encoding</description></item>
            /// <item><description><b>GBK</b>: GBK encoding</description></item>
            /// <item><description><b>ISO-8859-1</b>: ISO-8859-1 encoding</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("FileEncoding")]
            [Validation(Required=false)]
            public string FileEncoding { get; set; }

            /// <summary>
            /// <para>The format of the file for the data import. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SQL</b>: an SQL file</description></item>
            /// <item><description><b>CSV</b>: a CSV file</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip an error that occurs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: skips the error and continues to execute SQL statements.</description></item>
            /// <item><description><b>false</b>: stops executing SQL statements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }

            /// <summary>
            /// <para>The import mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FAST_MODE</b>: In the Execute step, the uploaded file is read and SQL statements are executed to import data to the specified destination database. Compared with the security mode, this mode can be used to import data in a less secure but more efficient manner.</description></item>
            /// <item><description><b>SAFE_MODE</b>: In the Precheck step, the uploaded file is parsed, and SQL statements or CSV file data is cached. In the Execute step, the cached SQL statements are read and executed to import data, or the cached CSV file data is read and imported to the specified destination database. This mode can be used to import data in a more secure but less efficient manner.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FAST_MODE</para>
            /// </summary>
            [NameInMap("ImportMode")]
            [Validation(Required=false)]
            public string ImportMode { get; set; }

            /// <summary>
            /// <para>The mode in which the data in the CSV format is to be written to the destination table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSERT</b>: The database checks the primary key when data is written. If a duplicate primary key value exists, an error message is returned.</description></item>
            /// <item><description><b>INSERT_IGNORE</b>: If the imported data contains data records that are the same as those in the destination table, the new data records are ignored.</description></item>
            /// <item><description><b>REPLACE_INTO</b>: If the imported data contains a row that has the same value for the primary key or unique index as one row in the destination table, the database deletes the existing row and inserts the new row into the destination table.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>FileType</b> parameter to <b>CSV</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>INSERT</para>
            /// </summary>
            [NameInMap("InsertType")]
            [Validation(Required=false)]
            public string InsertType { get; set; }

            /// <summary>
            /// <para>The key of the attachment that contains the SQL statements used to roll back the data import. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key from the value of the AttachmentKey parameter.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>RollbackSqlType</b> parameter to <b>ATTACHMENT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rollback.sql</para>
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// <para>The SQL statements used to roll back the data import.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>RollbackSqlType</b> parameter to <b>TEXT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <para>The format of the SQL statements used to roll back the data import. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEXT</b>: text</description></item>
            /// <item><description><b>ATTACHMENT</b>: attachment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

            /// <summary>
            /// <para>The destination table to which you want to import the data in the CSV format.</para>
            /// <remarks>
            /// <para> This parameter is required if you set the <b>FileType</b> parameter to <b>CSV</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Table_text</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The stakeholders of the data import. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than DMS administrators and database administrators (DBAs) are not allowed to view the ticket details.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
