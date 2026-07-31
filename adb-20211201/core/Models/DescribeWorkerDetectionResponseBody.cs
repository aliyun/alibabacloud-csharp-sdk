// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeWorkerDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-xxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The list of detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeWorkerDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeWorkerDetectionResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The detection result message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There are a total of 10 tables with an excessive number of primary keys.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>指标检测</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detection result.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public DescribeWorkerDetectionResponseBodyDetectionItemsResults Results { get; set; }
            public class DescribeWorkerDetectionResponseBodyDetectionItemsResults : TeaModel {
                /// <summary>
                /// <para>The aggregated operator metric detection results.</para>
                /// </summary>
                [NameInMap("OperatorAgg")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAgg> OperatorAgg { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAgg : TeaModel {
                    /// <summary>
                    /// <para>The name of the aggregated operator metric detection item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>峰值内存</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The collection of aggregated operator metric search results.</para>
                    /// </summary>
                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults : TeaModel {
                        /// <summary>
                        /// <para>The average value of the operator metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2234</para>
                        /// </summary>
                        [NameInMap("AvgValue")]
                        [Validation(Required=false)]
                        public double? AvgValue { get; set; }

                        /// <summary>
                        /// <para>The maximum value of the operator metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>444</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public long? MaxValue { get; set; }

                        /// <summary>
                        /// <para>The number of times the operator appears.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("OperatorCount")]
                        [Validation(Required=false)]
                        public long? OperatorCount { get; set; }

                        /// <summary>
                        /// <para>The operator name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Aggregation</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <para>The cumulative value of the operator metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("TotalValue")]
                        [Validation(Required=false)]
                        public long? TotalValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The collection of operator detection results.</para>
                /// </summary>
                [NameInMap("OperatorDetails")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetails> OperatorDetails { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetails : TeaModel {
                    /// <summary>
                    /// <para>The metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PeakMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The collection of search results.</para>
                    /// </summary>
                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults : TeaModel {
                        /// <summary>
                        /// <para>The number of input rows of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputRows")]
                        [Validation(Required=false)]
                        public long? InputRows { get; set; }

                        /// <summary>
                        /// <para>The input data size of the operator. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputSize")]
                        [Validation(Required=false)]
                        public long? InputSize { get; set; }

                        /// <summary>
                        /// <para>The total operator duration within the stage, which is equivalent to the CPU time of the stage. You can use this value to determine which parts of the query consume more compute resources. Unit: ms.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>23</para>
                        /// </summary>
                        [NameInMap("OperatorCost")]
                        [Validation(Required=false)]
                        public long? OperatorCost { get; set; }

                        /// <summary>
                        /// <para>The operator property information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Group By field: id</para>
                        /// </summary>
                        [NameInMap("OperatorInfo")]
                        [Validation(Required=false)]
                        public string OperatorInfo { get; set; }

                        /// <summary>
                        /// <para>The operator name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TableScan</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <para>The number of output rows of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("OutputRows")]
                        [Validation(Required=false)]
                        public long? OutputRows { get; set; }

                        /// <summary>
                        /// <para>The output data size of the operator. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("OutputSize")]
                        [Validation(Required=false)]
                        public long? OutputSize { get; set; }

                        /// <summary>
                        /// <para>The peak memory consumed by the operator. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>23</para>
                        /// </summary>
                        [NameInMap("PeakMemory")]
                        [Validation(Required=false)]
                        public long? PeakMemory { get; set; }

                        /// <summary>
                        /// <para>The SQL query ID, which can be used for diagnostics.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024041909301402103302422803151411141</para>
                        /// </summary>
                        [NameInMap("ProcessId")]
                        [Validation(Required=false)]
                        public string ProcessId { get; set; }

                        /// <summary>
                        /// <para>The stage ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Stage[2]</para>
                        /// </summary>
                        [NameInMap("StageId")]
                        [Validation(Required=false)]
                        public string StageId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The collection of tables with unreasonable partitions.</para>
                /// </summary>
                [NameInMap("PartitionedTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsPartitionedTables> PartitionedTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsPartitionedTables : TeaModel {
                    /// <summary>
                    /// <para>The CREATE TABLE statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>create table test(id varchar)</para>
                    /// </summary>
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public string DDL { get; set; }

                    /// <summary>
                    /// <para>The number of partitions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("PartitionCount")]
                    [Validation(Required=false)]
                    public string PartitionCount { get; set; }

                    /// <summary>
                    /// <para>The IDs of unreasonable partitions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[2024,2025]</para>
                    /// </summary>
                    [NameInMap("PartitionIds")]
                    [Validation(Required=false)]
                    public string PartitionIds { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nxg</para>
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhw_place_order</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The total data size of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("TotalDataSize")]
                    [Validation(Required=false)]
                    public long? TotalDataSize { get; set; }

                }

                /// <summary>
                /// <para>The table skew detection results.</para>
                /// </summary>
                [NameInMap("SkewedTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsSkewedTables> SkewedTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsSkewedTables : TeaModel {
                    /// <summary>
                    /// <para>The CREATE TABLE statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>create table test(id varchar)</para>
                    /// </summary>
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public string DDL { get; set; }

                    /// <summary>
                    /// <para>The number of partitions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PartitionCount")]
                    [Validation(Required=false)]
                    public int? PartitionCount { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>platfunc</para>
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// <para>The number of skewed rows in the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ShardSkewedRows")]
                    [Validation(Required=false)]
                    public string ShardSkewedRows { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sls_log_cheat_action</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The total data size of the table. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2345</para>
                    /// </summary>
                    [NameInMap("TotalDataSize")]
                    [Validation(Required=false)]
                    public long? TotalDataSize { get; set; }

                    /// <summary>
                    /// <para>The local data size. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2345</para>
                    /// </summary>
                    [NameInMap("TotalLocalDataSize")]
                    [Validation(Required=false)]
                    public string TotalLocalDataSize { get; set; }

                    /// <summary>
                    /// <para>The total primary key data size of the table. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("TotalPkSize")]
                    [Validation(Required=false)]
                    public long? TotalPkSize { get; set; }

                    /// <summary>
                    /// <para>The cold data size. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("TotalRemoteDataSize")]
                    [Validation(Required=false)]
                    public long? TotalRemoteDataSize { get; set; }

                    /// <summary>
                    /// <para>The total number of rows in the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("TotalRowCount")]
                    [Validation(Required=false)]
                    public long? TotalRowCount { get; set; }

                }

                /// <summary>
                /// <para>The collection of table access detection results.</para>
                /// </summary>
                [NameInMap("TopAccessTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTables> TopAccessTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTables : TeaModel {
                    /// <summary>
                    /// <para>The name of the detection metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Peak memory detection</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The collection of table access search results.</para>
                    /// </summary>
                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTablesSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTablesSearchResults : TeaModel {
                        /// <summary>
                        /// <para>The number of times the table was accessed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1111</para>
                        /// </summary>
                        [NameInMap("AccessCount")]
                        [Validation(Required=false)]
                        public long? AccessCount { get; set; }

                        /// <summary>
                        /// <para>The average scan duration. Unit: ms.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("AvgScanCost")]
                        [Validation(Required=false)]
                        public double? AvgScanCost { get; set; }

                        /// <summary>
                        /// <para>The average table read size. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("AvgScanSize")]
                        [Validation(Required=false)]
                        public double? AvgScanSize { get; set; }

                        /// <summary>
                        /// <para>The maximum scan duration. Unit: ms.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>345</para>
                        /// </summary>
                        [NameInMap("MaxScanCost")]
                        [Validation(Required=false)]
                        public long? MaxScanCost { get; set; }

                        /// <summary>
                        /// <para>The maximum data read size. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("MaxScanSize")]
                        [Validation(Required=false)]
                        public long? MaxScanSize { get; set; }

                        /// <summary>
                        /// <para>The table name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tiberias_2copt_origin_order_goods_info</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The detection result status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5B37B61-E6C9-5FE0-9374-45BAA548AEF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
