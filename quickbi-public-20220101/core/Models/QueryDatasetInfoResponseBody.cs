// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The dataset information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of tables used by the dataset.</para>
            /// </summary>
            [NameInMap("CubeTableList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultCubeTableList> CubeTableList { get; set; }
            public class QueryDatasetInfoResponseBodyResultCubeTableList : TeaModel {
                /// <summary>
                /// <para>The display name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_40</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The actual physical tables used by the merged table.</para>
                /// </summary>
                [NameInMap("ChildTables")]
                [Validation(Required=false)]
                public List<QueryDatasetInfoResponseBodyResultCubeTableListChildTables> ChildTables { get; set; }
                public class QueryDatasetInfoResponseBodyResultCubeTableListChildTables : TeaModel {
                    /// <summary>
                    /// <para>The display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Caption")]
                    [Validation(Required=false)]
                    public string Caption { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the table is a custom dataset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Customsql")]
                    [Validation(Required=false)]
                    public bool? Customsql { get; set; }

                    /// <summary>
                    /// <para>The data source ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("DatasourceId")]
                    [Validation(Required=false)]
                    public string DatasourceId { get; set; }

                    /// <summary>
                    /// <para>The data source type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("DsType")]
                    [Validation(Required=false)]
                    public string DsType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the table is the primary table.</para>
                    /// </summary>
                    [NameInMap("FactTable")]
                    [Validation(Required=false)]
                    public bool? FactTable { get; set; }

                    /// <summary>
                    /// <para>The SQL statement for the custom SQL dataset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Sql")]
                    [Validation(Required=false)]
                    public string Sql { get; set; }

                    /// <summary>
                    /// <para>The physical table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The unique ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the table is a custom SQL table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The table is a custom SQL table.</description></item>
                /// <item><description>false: The table is not a custom SQL table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Customsql")]
                [Validation(Required=false)]
                public bool? Customsql { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dfefd7f4-fc6e-42c9-b4******</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public string DatasourceId { get; set; }

                /// <summary>
                /// <para>The data source type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>mysql</description></item>
                /// <item><description>odps</description></item>
                /// <item><description>oracle</description></item>
                /// <item><description>Other data source types supported by Quick BI.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>Specifies whether the table is a data source table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The table is a data source table.</description></item>
                /// <item><description>false: The table is a custom table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FactTable")]
                [Validation(Required=false)]
                public bool? FactTable { get; set; }

                /// <summary>
                /// <para>The specific SQL statement when the table is a custom SQL table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from ****</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>viewdasb8494aab2612473cb74992159fe****</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The unique ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530b36</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether custom SQL is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CustimzeSql")]
            [Validation(Required=false)]
            public bool? CustimzeSql { get; set; }

            /// <summary>
            /// <para>The unique ID of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opds_40</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>The list of all dimensions in the dataset.</para>
            /// </summary>
            [NameInMap("DimensionList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultDimensionList> DimensionList { get; set; }
            public class QueryDatasetInfoResponseBodyResultDimensionList : TeaModel {
                /// <summary>
                /// <para>The display name of the dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The data type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>string: String.</description></item>
                /// <item><description>number: Number.</description></item>
                /// <item><description>datetime: Datetime.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The dimension type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard_dimension: Standard dimension.</description></item>
                /// <item><description>calculate_dimension: Calculated dimension.</description></item>
                /// <item><description>group_dimension: Grouped dimension.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>group_dimension</para>
                /// </summary>
                [NameInMap("DimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                /// <summary>
                /// <para>The expression for the calculated dimension. This parameter is valid only for calculated dimensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The flattened expression for the calculated dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ExpressionV2")]
                [Validation(Required=false)]
                public string ExpressionV2 { get; set; }

                /// <summary>
                /// <para>The actual physical field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                /// <summary>
                /// <para>The field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hhhh</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>The granularity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_granularity</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>The unique ID of the referenced field for a grouped measure. This parameter is not null only when the measure is a grouped measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>308f7****</para>
                /// </summary>
                [NameInMap("RefUid")]
                [Validation(Required=false)]
                public string RefUid { get; set; }

                /// <summary>
                /// <para>The unique ID of the table to which the dimension belongs. This corresponds to the UniqueId in CubeTypeList.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530***</para>
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// <para>The unique ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a69774***</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The folder information of the dataset.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryDatasetInfoResponseBodyResultDirectory Directory { get; set; }
            public class QueryDatasetInfoResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3eecab7-618d-4f9f-*****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The folder name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test folder</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The path of the folder ID, such as aa/bb/cc/dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88b680****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The path name of the folder ID, such as Level 1 folder/Level 2 folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test folder</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("DsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>mysql</description></item>
            /// <item><description>odps</description></item>
            /// <item><description>oracle</description></item>
            /// <item><description>Other data source types supported by Quick BI.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>The time when the dataset was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629450382000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the dataset was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629450382000</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// <para>The list of all measures in the dataset.</para>
            /// </summary>
            [NameInMap("MeasureList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultMeasureList> MeasureList { get; set; }
            public class QueryDatasetInfoResponseBodyResultMeasureList : TeaModel {
                /// <summary>
                /// <para>The display name of the measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profit_amt</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The data type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>string: String.</description></item>
                /// <item><description>number: Number.</description></item>
                /// <item><description>datetime: Datetime.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The expression for the calculated measure. This parameter is valid only for calculated measures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The flattened expression for the calculated measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ExpressionV2")]
                [Validation(Required=false)]
                public string ExpressionV2 { get; set; }

                /// <summary>
                /// <para>The actual physical field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profit_amt</para>
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                /// <summary>
                /// <para>The field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asadsda</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>The metric type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard_measure: Standard measure.</description></item>
                /// <item><description>calculate_measure: Calculated measure.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>calculate_measure</para>
                /// </summary>
                [NameInMap("MeasureType")]
                [Validation(Required=false)]
                public string MeasureType { get; set; }

                /// <summary>
                /// <para>The unique ID of the table to which the dimension belongs. This corresponds to the UniqueId in CubeTypeList.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530b36</para>
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// <para>The unique ID of the measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88b680****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether extract acceleration is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OpenOfflineAcceleration")]
            [Validation(Required=false)]
            public bool? OpenOfflineAcceleration { get; set; }

            /// <summary>
            /// <para>The user ID of the dataset owner in Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b8494aab26124*****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The name of the dataset owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dawa</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>Specifies whether row-level permissions are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RowLevel")]
            [Validation(Required=false)]
            public bool? RowLevel { get; set; }

            /// <summary>
            /// <para>The unique ID of the workspace to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>420abef4-a79b-4289-b12****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test workspace</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
