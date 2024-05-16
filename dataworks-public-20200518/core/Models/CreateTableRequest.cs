// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableRequest : TeaModel {
        /// <summary>
        /// The comment.
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// The ID of the logical level.
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// The schema information of the table. You need to enter the schema information of the table if you enable the table schema in MaxCompute.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateTableRequestColumns> Columns { get; set; }
        public class CreateTableRequestColumns : TeaModel {
            /// <summary>
            /// The comment of the field.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// The name of the field.
            /// 
            /// You can call the CreateTable operation to configure a maximum of 1,000 fields.
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// The sequence number of the field. You can use this parameter to specify how fields are sorted in a table. By default, fields are sorted in the order in which requests are created.
            /// 
            /// If the field is a partition field, this parameter is not supported.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// The data type of the field.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the topic.
            /// </summary>
            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

            /// <summary>
            /// Specifies whether the current field is a partition field.
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// The length of the field. For more information, see [MaxCompute V2.0 data type edition](~~159541#concept-2454988~~).
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

        }

        /// <summary>
        /// Specifies whether the MaxCompute table is a partitioned table. Valid values: 1 and 0. The value 1 indicates that the MaxCompute table is a partitioned table. The value 0 indicates that the MaxCompute table is not a partitioned table. This parameter is deprecated. Do not use this parameter.
        /// 
        /// The Column.N.isPartitionCol parameter is used to specify whether the MaxCompute table is a partitioned table. If the Column.N.isPartitionCol parameter is set to true, the MaxCompute table is a partitioned table.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The environment of the DataWorks workspace. Valid values:
        /// 
        /// *   0: development environment
        /// *   1: production environment
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The globally unique identifier (GUID) of the MaxCompute project. Specify the GUID in the odps.{projectName} format.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The storage location of the external table.
        /// </summary>
        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        /// <summary>
        /// Specifies whether the table or workspace is visible:
        /// 
        /// *   0: Both the table and workspace are not visible.
        /// *   1: The table and workspace are visible.
        /// *   2: Only the workspace is visible.
        /// </summary>
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        /// <summary>
        /// The ID of the associated category. You can call the [GetMetaCategory](https://help.aliyun.com/document_detail/173932.html) operation to query the ID of the category that can be associated.
        /// </summary>
        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace.
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// The ID of the physical level.
        /// </summary>
        [NameInMap("LogicalLevelId")]
        [Validation(Required=false)]
        public long? LogicalLevelId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The storage type of the external table. Valid values:
        /// 
        /// *   0: Object Storage Service (OSS)
        /// *   1: Tablestore
        /// *   2: Volume
        /// *   3: MySQL
        /// </summary>
        [NameInMap("PhysicsLevelId")]
        [Validation(Required=false)]
        public long? PhysicsLevelId { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The display name of the field.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// The endpoint of MaxCompute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<CreateTableRequestThemes> Themes { get; set; }
        public class CreateTableRequestThemes : TeaModel {
            /// <summary>
            /// The level that corresponds to the topic ID.
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("ThemeLevel")]
            [Validation(Required=false)]
            public int? ThemeLevel { get; set; }

        }

        /// <summary>
        /// The lifecycle of the table. Unit: days. By default, this parameter is left empty, which indicates that the table is permanently stored.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
