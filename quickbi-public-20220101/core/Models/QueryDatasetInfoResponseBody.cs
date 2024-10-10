// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether the operation is successfully returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The unique ID of the dataset.</para>
            /// </summary>
            [NameInMap("CubeTableList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultCubeTableList> CubeTableList { get; set; }
            public class QueryDatasetInfoResponseBodyResultCubeTableList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the data source table is valid. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: data source table</description></item>
                /// <item><description>false: custom table</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>odps_40</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The display name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Customsql")]
                [Validation(Required=false)]
                public bool? Customsql { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dfefd7f4-fc6e-42c9-b4******</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public string DatasourceId { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The unique ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FactTable")]
                [Validation(Required=false)]
                public bool? FactTable { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a custom SQL table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: custom SQL table</description></item>
                /// <item><description>false: non-custom SQL table</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>select * from ****</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>The list of tables used by the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>viewdasb8494aab2612473cb74992159fe****</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>mysql</description></item>
                /// <item><description>odps</description></item>
                /// <item><description>oracle</description></item>
                /// <item><description>... and other data source types supported by Quick BI</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530b36</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the workspace to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CustimzeSql")]
            [Validation(Required=false)]
            public bool? CustimzeSql { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>mysql</description></item>
            /// <item><description>odps</description></item>
            /// <item><description>oracle</description></item>
            /// <item><description>... Data source types supported by Quick BI such as</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The user ID of the dataset owner in the Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opds_40</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>If it is a custom SQL table, this is the specific SQL.</para>
            /// </summary>
            [NameInMap("DimensionList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultDimensionList> DimensionList { get; set; }
            public class QueryDatasetInfoResponseBodyResultDimensionList : TeaModel {
                /// <summary>
                /// <para>The unique ID of the field that is referenced by the group measure. Non-NULL if and only if the metric is a grouping metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>A list of all dimensions in the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The actual physical field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_dimension</para>
                /// </summary>
                [NameInMap("DimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                /// <summary>
                /// <para>Data type; value:</para>
                /// <list type="bullet">
                /// <item><description>string: character</description></item>
                /// <item><description>number: a number</description></item>
                /// <item><description>datetime: time</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>Expression for a calculated dimension; valid only for calculated dimensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hhhh</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>The type of the dimension. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard_dimension: General Dimension</description></item>
                /// <item><description>calculate_dimension: calculating dimensions</description></item>
                /// <item><description>group_dimension: grouping dimensions</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example_granularity</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>The granularity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>308f7****</para>
                /// </summary>
                [NameInMap("RefUid")]
                [Validation(Required=false)]
                public string RefUid { get; set; }

                /// <summary>
                /// <para>The ARN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530***</para>
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// <para>The display name of the dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a69774***</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the metric.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryDatasetInfoResponseBodyResultDirectory Directory { get; set; }
            public class QueryDatasetInfoResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>Test directory</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3eecab7-618d-4f9f-*****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Test directory</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the directory.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The information about the directory to which the dataset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88b680****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The path of the directory ID, for example, aa/bb/cc/dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The path name of the directory ID, for example, one-level directory /two-level directory.</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <para>The time when the dataset was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("DsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

            /// <summary>
            /// <para>The point in time when the training dataset was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>Indicates whether to customize SQL statements. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1629450382000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The information about the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629450382000</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// <para>The unique ID of the table to which the table belongs, which corresponds to the UniqueId of the CubeTypeList.</para>
            /// </summary>
            [NameInMap("MeasureList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultMeasureList> MeasureList { get; set; }
            public class QueryDatasetInfoResponseBodyResultMeasureList : TeaModel {
                /// <summary>
                /// <para>The actual physical field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profit_amt</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>A list of all measures for the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>Data type; value:</para>
                /// <list type="bullet">
                /// <item><description>string: character</description></item>
                /// <item><description>number: a number</description></item>
                /// <item><description>datetime: time</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example_expression</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The type of the measure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard_measure: General Metrics</description></item>
                /// <item><description>calculate_measure: Calculating Measures</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>profit_amt</para>
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hhhh</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>An expression that calculates a measure; valid only for calculated measures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>calculate_measure</para>
                /// </summary>
                [NameInMap("MeasureType")]
                [Validation(Required=false)]
                public string MeasureType { get; set; }

                /// <summary>
                /// <para>The display name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a62530b36</para>
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// <para>The unique ID of the table to which the table belongs, which corresponds to the UniqueId of the CubeTypeList.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88b680****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("OpenOfflineAcceleration")]
            [Validation(Required=false)]
            public bool? OpenOfflineAcceleration { get; set; }

            /// <summary>
            /// <para>Test Space</para>
            /// 
            /// <b>Example:</b>
            /// <para>b8494aab26124*****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The unique ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the dataset owner.</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The name of the training dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RowLevel")]
            [Validation(Required=false)]
            public bool? RowLevel { get; set; }

            /// <summary>
            /// <para>Whether row-level permissions are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The VIP Netty channel is enabled.</description></item>
            /// <item><description>false: The VIP Netty channel is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>420abef4-a79b-4289-b12****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>Big Baby</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the workspace in which the dataset resides.</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
