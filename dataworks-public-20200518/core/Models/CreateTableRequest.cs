// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the MaxCompute project. The format is odps.{projectName}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test</para>
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// <para>The ID of the associated category. You can call the <a href="https://help.aliyun.com/document_detail/173932.html">GetMetaCategory</a> operation to query the IDs of available categories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of columns. A maximum of 1,000 columns are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateTableRequestColumns> Columns { get; set; }
        public class CreateTableRequestColumns : TeaModel {
            /// <summary>
            /// <para>The name of the column. The CreateTable operation supports a maximum of 1,000 columns.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>columnName1</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The Chinese name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中文名</para>
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// <para>The data type of the column. The supported data types depend on the data type edition used by your MaxCompute project. For more information about the data types supported by each edition, see <a href="https://help.aliyun.com/document_detail/27821.html">Data type editions</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// <para>The description of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Specifies whether the current column is a partition column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

            /// <summary>
            /// <para>The length of the column. For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://help.aliyun.com/document_detail/159541.html">Data type editions</a>&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/159541.html">Data type editions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// <para>The sequence number of the column. You can specify the order of columns in the table. By default, columns are sorted in the order they are specified in the creation request. If the column is a partition column, you cannot configure Columns.N.SeqNumber.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comment</para>
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
        /// <para>The environment of the DataWorks workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment.</description></item>
        /// <item><description>1: production environment.</description></item>
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
        /// <item><description>0: OSS.</description></item>
        /// <item><description>1: Tablestore.</description></item>
        /// <item><description>2: Volume.</description></item>
        /// <item><description>3: MySQL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        /// <summary>
        /// <para>Specifies whether the created MaxCompute table is a partitioned table. Valid values: 1 (yes) and 0 (no). <b>[Deprecated]</b> Do not use this parameter. The system determines whether the MaxCompute table is a partitioned table based on the Column.N.isPartitionCol parameter. If the Column.N.isPartitionCol parameter is set to true, the MaxCompute table is considered a partitioned table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a view or a table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: table.</description></item>
        /// <item><description>1: view.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        /// <summary>
        /// <para>The lifecycle of the table, in days. The default value is empty, which indicates permanent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        /// <summary>
        /// <para>The storage address of the external table.</para>
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
        /// <para>The ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The schema information of the table. In MaxCompute, you must specify the schema information when the three-level model is enabled.</para>
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
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<CreateTableRequestThemes> Themes { get; set; }
        public class CreateTableRequestThemes : TeaModel {
            /// <summary>
            /// <para>The ID of the theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            /// <summary>
            /// <para>The theme level corresponding to the theme ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ThemeLevel")]
            [Validation(Required=false)]
            public int? ThemeLevel { get; set; }

        }

        /// <summary>
        /// <para>Specifies the visibility of the table and the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The table and the workspace are both invisible.</description></item>
        /// <item><description>1: The table and the workspace are both visible.</description></item>
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
