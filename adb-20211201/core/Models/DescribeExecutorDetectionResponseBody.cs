// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeExecutorDetectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>am-xxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeExecutorDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeExecutorDetectionResponseBodyDetectionItems : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public DescribeExecutorDetectionResponseBodyDetectionItemsResults Results { get; set; }
            public class DescribeExecutorDetectionResponseBodyDetectionItemsResults : TeaModel {
                [NameInMap("OperatorAgg")]
                [Validation(Required=false)]
                public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAgg> OperatorAgg { get; set; }
                public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAgg : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OperatorCost</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults> SearchResults { get; set; }
                    public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorAggSearchResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("AvgValue")]
                        [Validation(Required=false)]
                        public double? AvgValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public long? MaxValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("OperatorCount")]
                        [Validation(Required=false)]
                        public long? OperatorCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Window</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>345</para>
                        /// </summary>
                        [NameInMap("TotalValue")]
                        [Validation(Required=false)]
                        public long? TotalValue { get; set; }

                    }

                }

                [NameInMap("OperatorDetails")]
                [Validation(Required=false)]
                public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetails> OperatorDetails { get; set; }
                public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PeakMemory</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("SearchResults")]
                    [Validation(Required=false)]
                    public List<DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults> SearchResults { get; set; }
                    public class DescribeExecutorDetectionResponseBodyDetectionItemsResultsOperatorDetailsSearchResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InputRows")]
                        [Validation(Required=false)]
                        public long? InputRows { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>345</para>
                        /// </summary>
                        [NameInMap("InputSize")]
                        [Validation(Required=false)]
                        public long? InputSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("OperatorCost")]
                        [Validation(Required=false)]
                        public double? OperatorCost { get; set; }

                        [NameInMap("OperatorInfo")]
                        [Validation(Required=false)]
                        public string OperatorInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Join</para>
                        /// </summary>
                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2345</para>
                        /// </summary>
                        [NameInMap("OutputRows")]
                        [Validation(Required=false)]
                        public long? OutputRows { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("OutputSize")]
                        [Validation(Required=false)]
                        public long? OutputSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>234</para>
                        /// </summary>
                        [NameInMap("PeakMemory")]
                        [Validation(Required=false)]
                        public long? PeakMemory { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024080110010002102500023803151627972</para>
                        /// </summary>
                        [NameInMap("ProcessId")]
                        [Validation(Required=false)]
                        public string ProcessId { get; set; }

                        /// <summary>
                        /// <para>StageID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Stage[3]</para>
                        /// </summary>
                        [NameInMap("StageId")]
                        [Validation(Required=false)]
                        public string StageId { get; set; }

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
        /// <para>9DFF5F54-162B-5860-80A5-411FF550B347</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>566</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
