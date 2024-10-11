// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskReportsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>16B78383-2803-4964-9605-37B30C073B0E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFlowControlTaskReportsResponseBodyResult Result { get; set; }
        public class ListFlowControlTaskReportsResponseBodyResult : TeaModel {
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<ListFlowControlTaskReportsResponseBodyResultMetrics> Metrics { get; set; }
            public class ListFlowControlTaskReportsResponseBodyResultMetrics : TeaModel {
                [NameInMap("details")]
                [Validation(Required=false)]
                public List<ListFlowControlTaskReportsResponseBodyResultMetricsDetails> Details { get; set; }
                public class ListFlowControlTaskReportsResponseBodyResultMetricsDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1664035200</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1664000452</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("val")]
                    [Validation(Required=false)]
                    public long? Val { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>taskPv</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public ListFlowControlTaskReportsResponseBodyResultTotal Total { get; set; }
            public class ListFlowControlTaskReportsResponseBodyResultTotal : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("InvalidPercent")]
                [Validation(Required=false)]
                public double? InvalidPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("accTaskCtr")]
                [Validation(Required=false)]
                public double? AccTaskCtr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("accTaskPv")]
                [Validation(Required=false)]
                public long? AccTaskPv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("accTotalCtr")]
                [Validation(Required=false)]
                public double? AccTotalCtr { get; set; }

            }

        }

    }

}
