// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetInfoResponseBody : TeaModel {
        /// <summary>
        /// Whether the operation is successfully returned. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// The unique ID of the dataset.
            /// </summary>
            [NameInMap("CubeTableList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultCubeTableList> CubeTableList { get; set; }
            public class QueryDatasetInfoResponseBodyResultCubeTableList : TeaModel {
                /// <summary>
                /// Indicates whether the data source table is valid. Valid values:
                /// 
                /// *   true: data source table
                /// *   false: custom table
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// The display name of the table.
                /// </summary>
                [NameInMap("Customsql")]
                [Validation(Required=false)]
                public bool? Customsql { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public string DatasourceId { get; set; }

                /// <summary>
                /// The ID of the data source.
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// The unique ID of the table.
                /// </summary>
                [NameInMap("FactTable")]
                [Validation(Required=false)]
                public bool? FactTable { get; set; }

                /// <summary>
                /// Indicates whether the table is a custom SQL table. Valid values:
                /// 
                /// *   true: custom SQL table
                /// *   false: non-custom SQL table
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// The list of tables used by the dataset.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   mysql
                /// *   odps
                /// *   oracle
                /// *   ... and other data source types supported by Quick BI
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

            }

            /// <summary>
            /// The unique ID of the workspace to which the dataset belongs.
            /// </summary>
            [NameInMap("CustimzeSql")]
            [Validation(Required=false)]
            public bool? CustimzeSql { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   mysql
            /// *   odps
            /// *   oracle
            /// *   ... Data source types supported by Quick BI such as
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// The user ID of the dataset owner in the Quick BI.
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// If it is a custom SQL table, this is the specific SQL.
            /// </summary>
            [NameInMap("DimensionList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultDimensionList> DimensionList { get; set; }
            public class QueryDatasetInfoResponseBodyResultDimensionList : TeaModel {
                /// <summary>
                /// The unique ID of the field that is referenced by the group measure. Non-NULL if and only if the metric is a grouping metric.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// A list of all dimensions in the dataset.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The actual physical field.
                /// </summary>
                [NameInMap("DimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                /// <summary>
                /// Data type; value:
                /// 
                /// *   string: character
                /// *   number: a number
                /// *   datetime: time
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// Expression for a calculated dimension; valid only for calculated dimensions.
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// The type of the dimension. Valid values:
                /// 
                /// *   standard_dimension: General Dimension
                /// *   calculate_dimension: calculating dimensions
                /// *   group_dimension: grouping dimensions
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// The granularity.
                /// </summary>
                [NameInMap("RefUid")]
                [Validation(Required=false)]
                public string RefUid { get; set; }

                /// <summary>
                /// The ARN.
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// The display name of the dimension.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// The unique ID of the metric.
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryDatasetInfoResponseBodyResultDirectory Directory { get; set; }
            public class QueryDatasetInfoResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// Test directory
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Test directory
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The information about the directory to which the dataset belongs.
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// The path of the directory ID, for example, aa/bb/cc/dd.
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// The time when the dataset was last modified.
            /// </summary>
            [NameInMap("DsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

            /// <summary>
            /// The point in time when the training dataset was created.
            /// </summary>
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// Indicates whether to customize SQL statements. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The information about the dataset.
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// The unique ID of the table to which the table belongs, which corresponds to the UniqueId of the CubeTypeList.
            /// </summary>
            [NameInMap("MeasureList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultMeasureList> MeasureList { get; set; }
            public class QueryDatasetInfoResponseBodyResultMeasureList : TeaModel {
                /// <summary>
                /// The actual physical field.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// A list of all measures for the dataset.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// Data type; value:
                /// 
                /// *   string: character
                /// *   number: a number
                /// *   datetime: time
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// The type of the measure. Valid values:
                /// 
                /// *   standard_measure: General Metrics
                /// *   calculate_measure: Calculating Measures
                /// </summary>
                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// An expression that calculates a measure; valid only for calculated measures.
                /// </summary>
                [NameInMap("MeasureType")]
                [Validation(Required=false)]
                public string MeasureType { get; set; }

                /// <summary>
                /// The display name of the metric.
                /// </summary>
                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                /// <summary>
                /// The unique ID of the table to which the table belongs, which corresponds to the UniqueId of the CubeTypeList.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("OpenOfflineAcceleration")]
            [Validation(Required=false)]
            public bool? OpenOfflineAcceleration { get; set; }

            /// <summary>
            /// Test Space
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The unique ID of the data source.
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// The name of the training dataset.
            /// </summary>
            [NameInMap("RowLevel")]
            [Validation(Required=false)]
            public bool? RowLevel { get; set; }

            /// <summary>
            /// Whether row-level permissions are enabled. Valid values:
            /// 
            /// *   true: The VIP Netty channel is enabled.
            /// *   false: The VIP Netty channel is disabled.
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// Big Baby
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// The unique ID of the dataset.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
