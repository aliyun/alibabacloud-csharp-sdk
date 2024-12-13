// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the MaxCompute project. Specify the GUID in the odps.{projectName} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test</para>
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// <para>The ID of the associated category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<UpdateTableRequestColumns> Columns { get; set; }
        public class UpdateTableRequestColumns : TeaModel {
            /// <summary>
            /// <para>The name of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The display name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// <para>The type of the field. For more information, see MaxCompute field types.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// <para>The comment of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Specifies whether the field is a partition field. Valid values: 0 and 1. The value 0 indicates that the field is not a partition field. The value 1 indicates that the field is a partition field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

            /// <summary>
            /// <para>The length of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// <para>The sequence number of the field. If the field is a partition field, this parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

        }

        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether the table exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The table exists.</description></item>
        /// <item><description>false: The table does not exist.</description></item>
        /// </list>
        /// <para>This parameter is deprecated. Do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreateIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateIfNotExists { get; set; }

        /// <summary>
        /// <para>The endpoint of MaxCompute. If you do not specify this parameter, the endpoint of the MaxCompute project is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps://</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The environment of the DataWorks workspace. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The type of the external table. Valid values: 0, 1, 2, and 3. The value 0 indicates that the external table is an OSS external table. The value 1 indicates that the external table is a Tablestore external table. The value 2 indicates that the external table is a volume external table. The value 3 indicates that the external table is a MySQL external table. This parameter is deprecated. Do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        /// <summary>
        /// <para>Specifies whether the table that you want to update is a partitioned table. Valid values: 0 and 1. The value 0 indicates that the table is not a partitioned table. The value 1 indicates that the table is a partitioned table. This parameter is deprecated. Do not use this parameter. The Column.N.isPartitionCol parameter is used instead of the HasPart parameter to specify whether the MaxCompute table is a partitioned table. If the Column.N.isPartitionCol parameter is set to 1, the MaxCompute table is a partitioned table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        /// <summary>
        /// <para>Specifies whether the table is a view. Valid values: 0 and 1. The value 0 indicates that the table is not a view. The value 1 indicates that the table is a view. This parameter is deprecated. Do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        /// <summary>
        /// <para>The lifecycle of the table. Unit: days. If this parameter is left empty, the table is permanently stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        /// <summary>
        /// <para>The storage location of the external table. This parameter is deprecated. Do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>location</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The ID of the logical level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("LogicalLevelId")]
        [Validation(Required=false)]
        public long? LogicalLevelId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the physical layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("PhysicsLevelId")]
        [Validation(Required=false)]
        public long? PhysicsLevelId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console to obtain the ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The schema information of the table. You need to enter the schema information of the table if you enable the table schema in MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<UpdateTableRequestThemes> Themes { get; set; }
        public class UpdateTableRequestThemes : TeaModel {
            /// <summary>
            /// <para>The ID of the associated topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            /// <summary>
            /// <para>The level that corresponds to the topic ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeLevel")]
            [Validation(Required=false)]
            public int? ThemeLevel { get; set; }

        }

        /// <summary>
        /// <para>The scope in which the table is visible. Valid values: 0, 1, and 2. The value 0 indicates that the table is invisible to all workspace members. The value 1 indicates that the table is visible to all workspace members. The value 2 indicates that the table is visible to workspace members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
