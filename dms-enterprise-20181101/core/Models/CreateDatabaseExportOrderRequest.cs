// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDatabaseExportOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to obtain the attachment key.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The purpose or objective of the ticket. This parameter helps reduce unnecessary communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the parent ticket.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public CreateDatabaseExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDatabaseExportOrderRequestPluginParam : TeaModel {
            /// <summary>
            /// The reason for the database export.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The configurations for database export.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public CreateDatabaseExportOrderRequestPluginParamConfig Config { get; set; }
            public class CreateDatabaseExportOrderRequestPluginParamConfig : TeaModel {
                /// <summary>
                /// The export options for big data. The options are used to filter the big data to be exported. You can leave this parameter empty.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DataOption")]
                [Validation(Required=false)]
                public List<string> DataOption { get; set; }

                /// <summary>
                /// The type of data that you want to export. Valid values:
                /// 
                /// *   **DATA**: The data of the database is exported.
                /// *   **STRUCT**: The schema of the database is exported.
                /// *   **DATA_STRUCT**: The data and schema of the database are exported.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("ExportContent")]
                [Validation(Required=false)]
                public string ExportContent { get; set; }

                /// <summary>
                /// The types of schemas that you want to export.
                /// </summary>
                [NameInMap("ExportTypes")]
                [Validation(Required=false)]
                public List<string> ExportTypes { get; set; }

                /// <summary>
                /// The extension options of the SQL script. You can leave this parameter empty.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SQLExtOption")]
                [Validation(Required=false)]
                public List<string> SQLExtOption { get; set; }

                /// <summary>
                /// The tables that you want to export.
                /// </summary>
                [NameInMap("SelectedTables")]
                [Validation(Required=false)]
                public List<string> SelectedTables { get; set; }

                /// <summary>
                /// The conditions used to filter the tables to be exported.
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public Dictionary<string, string> Tables { get; set; }

                /// <summary>
                /// The format in which the database is exported. Valid values:
                /// 
                /// *   **SQL**
                /// *   **CSV**
                /// *   **XLSX**
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TargetOption")]
                [Validation(Required=false)]
                public string TargetOption { get; set; }

            }

            /// <summary>
            /// The database ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The instance ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// Specifies whether the database is a logical database. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The name that is used to search for the database.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// The stakeholders involved in this operation.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The tenant ID.
        /// 
        /// > To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html) section of the "Manage DMS tenants" topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
