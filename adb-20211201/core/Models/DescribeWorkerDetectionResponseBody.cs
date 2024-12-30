// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeWorkerDetectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>am-xxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeWorkerDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeWorkerDetectionResponseBodyDetectionItems : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public DescribeWorkerDetectionResponseBodyDetectionItemsResults Results { get; set; }
            public class DescribeWorkerDetectionResponseBodyDetectionItemsResults : TeaModel {
                [NameInMap("OperatorAgg")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAgg> OperatorAgg { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAgg : TeaModel {
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2234</para>
                        /// </summary>
                        [NameInMap("AvgValue")]
                        [Validation(Required=false)]
                        public double? AvgValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>444</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public long? MaxValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("OperatorCount")]
                        [Validation(Required=false)]
                        public long? OperatorCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Aggregation</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("TotalValue")]
                        [Validation(Required=false)]
                        public long? TotalValue { get; set; }

                    }

                }

                [NameInMap("OperatorDetails")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetails> OperatorDetails { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PeakMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputRows")]
                        [Validation(Required=false)]
                        public long? InputRows { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputSize")]
                        [Validation(Required=false)]
                        public long? InputSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>23</para>
                        /// </summary>
                        [NameInMap("OperatorCost")]
                        [Validation(Required=false)]
                        public long? OperatorCost { get; set; }

                        [NameInMap("OperatorInfo")]
                        [Validation(Required=false)]
                        public string OperatorInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TableScan</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("OutputRows")]
                        [Validation(Required=false)]
                        public long? OutputRows { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("OutputSize")]
                        [Validation(Required=false)]
                        public long? OutputSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>23</para>
                        /// </summary>
                        [NameInMap("PeakMemory")]
                        [Validation(Required=false)]
                        public long? PeakMemory { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024041909301402103302422803151411141</para>
                        /// </summary>
                        [NameInMap("ProcessId")]
                        [Validation(Required=false)]
                        public string ProcessId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Stage[2]</para>
                        /// </summary>
                        [NameInMap("StageId")]
                        [Validation(Required=false)]
                        public string StageId { get; set; }

                    }

                }

                [NameInMap("PartitionedTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsPartitionedTables> PartitionedTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsPartitionedTables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>create table test(id varchar)</para>
                    /// </summary>
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public string DDL { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("PartitionCount")]
                    [Validation(Required=false)]
                    public string PartitionCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[2024,2025]</para>
                    /// </summary>
                    [NameInMap("PartitionIds")]
                    [Validation(Required=false)]
                    public string PartitionIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nxg</para>
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zhw_place_order</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("TotalDataSize")]
                    [Validation(Required=false)]
                    public long? TotalDataSize { get; set; }

                }

                [NameInMap("SkewedTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsSkewedTables> SkewedTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsSkewedTables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>create table test(id varchar)</para>
                    /// </summary>
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public string DDL { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PartitionCount")]
                    [Validation(Required=false)]
                    public int? PartitionCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>platfunc</para>
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ShardSkewedRows")]
                    [Validation(Required=false)]
                    public string ShardSkewedRows { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sls_log_cheat_action</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2345</para>
                    /// </summary>
                    [NameInMap("TotalDataSize")]
                    [Validation(Required=false)]
                    public long? TotalDataSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2345</para>
                    /// </summary>
                    [NameInMap("TotalLocalDataSize")]
                    [Validation(Required=false)]
                    public string TotalLocalDataSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("TotalPkSize")]
                    [Validation(Required=false)]
                    public long? TotalPkSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("TotalRemoteDataSize")]
                    [Validation(Required=false)]
                    public long? TotalRemoteDataSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("TotalRowCount")]
                    [Validation(Required=false)]
                    public long? TotalRowCount { get; set; }

                }

                [NameInMap("TopAccessTables")]
                [Validation(Required=false)]
                public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTables> TopAccessTables { get; set; }
                public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTables : TeaModel {
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTablesSearchResults> SearchResults { get; set; }
                    public class DescribeWorkerDetectionResponseBodyDetectionItemsResultsTopAccessTablesSearchResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1111</para>
                        /// </summary>
                        [NameInMap("AccessCount")]
                        [Validation(Required=false)]
                        public long? AccessCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("AvgScanCost")]
                        [Validation(Required=false)]
                        public double? AvgScanCost { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("AvgScanSize")]
                        [Validation(Required=false)]
                        public double? AvgScanSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>345</para>
                        /// </summary>
                        [NameInMap("MaxScanCost")]
                        [Validation(Required=false)]
                        public long? MaxScanCost { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("MaxScanSize")]
                        [Validation(Required=false)]
                        public long? MaxScanSize { get; set; }

                        /// <summary>
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
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E5B37B61-E6C9-5FE0-9374-45BAA548AEF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
