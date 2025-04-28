// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeExecutorDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-xxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeExecutorDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeExecutorDetectionResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The information about the detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Large amounts of memory resources are used by the Aggregation operator.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU increase detection</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detection result items.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public DescribeExecutorDetectionResponseBodyDetectionItemsResults Results { get; set; }
            public class DescribeExecutorDetectionResponseBodyDetectionItemsResults : TeaModel {
                /// <summary>
                /// <para>The detection result items of operator metric aggregation.</para>
                /// </summary>
                [NameInMap("OperatorAgg")]
                [Validation(Required=false)]
                public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAgg> OperatorAgg { get; set; }
                public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAgg : TeaModel {
                    /// <summary>
                    /// <para>The name of the detection metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PeakMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The detection result items of operator metric aggregation.</para>
                    /// </summary>
                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults> SearchResults { get; set; }
                    public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults : TeaModel {
                        /// <summary>
                        /// <para>The average value of the operator metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>235.5</para>
                        /// </summary>
                        [NameInMap("AvgValue")]
                        [Validation(Required=false)]
                        public double? AvgValue { get; set; }

                        /// <summary>
                        /// <para>The maximum value of the operator metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2335</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public long? MaxValue { get; set; }

                        /// <summary>
                        /// <para>The number of occurrences of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("OperatorCount")]
                        [Validation(Required=false)]
                        public long? OperatorCount { get; set; }

                        /// <summary>
                        /// <para>The name of the operator.</para>
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
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("TotalValue")]
                        [Validation(Required=false)]
                        public long? TotalValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The detection result items of abnormal operators.</para>
                /// </summary>
                [NameInMap("OperatorDetails")]
                [Validation(Required=false)]
                public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetails> OperatorDetails { get; set; }
                public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetails : TeaModel {
                    /// <summary>
                    /// <para>The name of the detection metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PeakMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The detection result items of abnormal operators.</para>
                    /// </summary>
                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults> SearchResults { get; set; }
                    public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults : TeaModel {
                        /// <summary>
                        /// <para>The number of rows input by the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputRows")]
                        [Validation(Required=false)]
                        public long? InputRows { get; set; }

                        /// <summary>
                        /// <para>The amount of data input by the operator. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("InputSize")]
                        [Validation(Required=false)]
                        public long? InputSize { get; set; }

                        /// <summary>
                        /// <para>The total CPU time consumed by all operators in the stage, which is equivalent to the total CPU time of the stage. You can use this parameter to determine which parts of the stage consume a large amount of computing resources. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2354</para>
                        /// </summary>
                        [NameInMap("OperatorCost")]
                        [Validation(Required=false)]
                        public double? OperatorCost { get; set; }

                        /// <summary>
                        /// <para>The property information about the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GROUP BY field: uid</para>
                        /// </summary>
                        [NameInMap("OperatorInfo")]
                        [Validation(Required=false)]
                        public string OperatorInfo { get; set; }

                        /// <summary>
                        /// <para>The name of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TableScan</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <para>The number of rows output by the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2354</para>
                        /// </summary>
                        [NameInMap("OutputRows")]
                        [Validation(Required=false)]
                        public long? OutputRows { get; set; }

                        /// <summary>
                        /// <para>The amount of data output by the operator. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("OutputSize")]
                        [Validation(Required=false)]
                        public long? OutputSize { get; set; }

                        /// <summary>
                        /// <para>The peak memory of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2334</para>
                        /// </summary>
                        [NameInMap("PeakMemory")]
                        [Validation(Required=false)]
                        public long? PeakMemory { get; set; }

                        /// <summary>
                        /// <para>The query ID that can be used for diagnostics.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>202405061006230110150170540315119xxxx</para>
                        /// </summary>
                        [NameInMap("ProcessId")]
                        [Validation(Required=false)]
                        public string ProcessId { get; set; }

                        /// <summary>
                        /// <para>The stage ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Stage[7]</para>
                        /// </summary>
                        [NameInMap("StageId")]
                        [Validation(Required=false)]
                        public string StageId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
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
        /// <para>B20BA053-27A1-5FDF-B063-6D6146720DF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
