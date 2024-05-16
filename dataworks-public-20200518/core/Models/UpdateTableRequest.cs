// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableRequest : TeaModel {
        /// <summary>
        /// Specifies whether the table exists. Valid values:
        /// 
        /// *   true: The table exists.
        /// *   false: The table does not exist.
        /// 
        /// This parameter is deprecated. Do not use this parameter.
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

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<UpdateTableRequestColumns> Columns { get; set; }
        public class UpdateTableRequestColumns : TeaModel {
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
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// The sequence number of the field. If the field is a partition field, this parameter is not supported.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// The type of the field. For more information, see MaxCompute field types.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the associated topic.
            /// </summary>
            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

            /// <summary>
            /// Specifies whether the field is a partition field. Valid values: 0 and 1. The value 0 indicates that the field is not a partition field. The value 1 indicates that the field is a partition field.
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// The length of the field.
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

        }

        /// <summary>
        /// The schema information of the table. You need to enter the schema information of the table if you enable the table schema in MaxCompute.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Specifies whether the table that you want to update is a partitioned table. Valid values: 0 and 1. The value 0 indicates that the table is not a partitioned table. The value 1 indicates that the table is a partitioned table. This parameter is deprecated. Do not use this parameter.
        /// 
        /// The Column.N.isPartitionCol parameter is used instead of the HasPart parameter to specify whether the MaxCompute table is a partitioned table. If the Column.N.isPartitionCol parameter is set to 1, the MaxCompute table is a partitioned table.
        /// </summary>
        [NameInMap("CreateIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateIfNotExists { get; set; }

        /// <summary>
        /// The environment of the DataWorks workspace. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.
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
        /// The storage location of the external table. This parameter is deprecated. Do not use this parameter.
        /// </summary>
        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        /// <summary>
        /// The comment.
        /// </summary>
        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        /// <summary>
        /// The scope in which the table is visible. Valid values: 0, 1, and 2. The value 0 indicates that the table is invisible to all workspace members. The value 1 indicates that the table is visible to all workspace members. The value 2 indicates that the table is visible to workspace members.
        /// </summary>
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        /// <summary>
        /// The ID of the associated category.
        /// </summary>
        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the DataWorks console to obtain the ID of the DataWorks workspace.
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
        /// The type of the external table. Valid values: 0, 1, 2, and 3. The value 0 indicates that the external table is an OSS external table. The value 1 indicates that the external table is a Tablestore external table. The value 2 indicates that the external table is a volume external table. The value 3 indicates that the external table is a MySQL external table. This parameter is deprecated. Do not use this parameter.
        /// </summary>
        [NameInMap("PhysicsLevelId")]
        [Validation(Required=false)]
        public long? PhysicsLevelId { get; set; }

        /// <summary>
        /// The name of the MaxCompute table.
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
        /// The endpoint of MaxCompute. If this parameter is left empty, the endpoint of the MaxCompute project is used.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<UpdateTableRequestThemes> Themes { get; set; }
        public class UpdateTableRequestThemes : TeaModel {
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
        /// The lifecycle of the table. Unit: days. If this parameter is left empty, the table is permanently stored.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
