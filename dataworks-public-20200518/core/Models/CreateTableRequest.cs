// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the MaxCompute project. Specify the ID in the odps.{projectName} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test</para>
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// <para>The ID of the associated category. You can call the <a href="https://help.aliyun.com/document_detail/173932.html">GetMetaCategory</a> operation to query the IDs of all categories that can be associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reserved</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of fields. A maximum of 1,000 fields are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateTableRequestColumns> Columns { get; set; }
        public class CreateTableRequestColumns : TeaModel {
            /// <summary>
            /// <para>The name of the field. You can configure a maximum of 1,000 fields when you call the CreateTable operation to create a table.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>columnName1</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The display name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>columnName in chinese</para>
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// <para>The data type of the field. For information about supported data types, see <a href="https://help.aliyun.com/document_detail/27821.html">Data type editions</a> in MaxCompute documentation.</para>
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
            /// <para>Specifies whether the field is a partition field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

            /// <summary>
            /// <para>The length of the field. For more information, see <a href="https://help.aliyun.com/document_detail/159541.html">MaxCompute data type editions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// <para>The sequence number of the field. You can use this parameter to specify how fields are sorted in a table. By default, fields are sorted based on the order in which requests are created. If the field is a partition field, this parameter is not supported.</para>
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
        /// <para>The endpoint of MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps://abc</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The environment type of the DataWorks workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment</description></item>
        /// <item><description>1: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The storage type of the external table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Object Storage Service (OSS)</description></item>
        /// <item><description>1: Tablestore</description></item>
        /// <item><description>2: Volume</description></item>
        /// <item><description>3: MySQL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a MaxCompute partitioned table. Valid values: 1 and 0. The value 1 indicates a partitioned table. The value 0 indicates a non-partitioned table. This parameter is deprecated. Do not use this parameter. The Column.N.isPartitionCol parameter is used to specify whether to create a MaxCompute partitioned table. If the Column.N.isPartitionCol parameter is set to true, a MaxCompute partitioned table is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a view or table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Create a table.</description></item>
        /// <item><description>1: Create a view.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        /// <summary>
        /// <para>The lifecycle of the table. Unit: days. By default, this parameter is left empty, which indicates that the table is permanently stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        /// <summary>
        /// <para>The storage location of the external table.</para>
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
        /// <para>The ID of the physical level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("PhysicsLevelId")]
        [Validation(Required=false)]
        public long? PhysicsLevelId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
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
        /// <para>The name of the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tableName1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The list of themes.</para>
        /// </summary>
        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<CreateTableRequestThemes> Themes { get; set; }
        public class CreateTableRequestThemes : TeaModel {
            /// <summary>
            /// <para>The theme ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            /// <summary>
            /// <para>The level that corresponds to the theme ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeLevel")]
            [Validation(Required=false)]
            public int? ThemeLevel { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the table or workspace is visible. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Both the table and workspace are invisible.</description></item>
        /// <item><description>1: Both the table and workspace are visible.</description></item>
        /// <item><description>2: Only the workspace is visible.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
