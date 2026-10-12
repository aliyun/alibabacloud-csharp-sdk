// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricLastResponseBody : TeaModel {
        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of instance monitoring results.</para>
        /// </summary>
        [NameInMap("MetricTotalModel")]
        [Validation(Required=false)]
        public List<DescribeMetricLastResponseBodyMetricTotalModel> MetricTotalModel { get; set; }
        public class DescribeMetricLastResponseBodyMetricTotalModel : TeaModel {
            /// <summary>
            /// <para>The cloud phone instance ID returned for instance-level monitoring. 
            /// &lt;props=&quot;china&quot;&gt;The matrix ID returned for matrix-level monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyru4p****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The list of metric monitoring results.</para>
            /// </summary>
            [NameInMap("MetricModelList")]
            [Validation(Required=false)]
            public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelList> MetricModelList { get; set; }
            public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelList : TeaModel {
                /// <summary>
                /// <para>The list of monitoring statistics data points.</para>
                /// </summary>
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelListDataPoints> DataPoints { get; set; }
                public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelListDataPoints : TeaModel {
                    /// <summary>
                    /// <para>The average value. Unit: %.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the monitoring metric is bandwidth_package_usage_out or bandwidth_package_usage_in.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.52</para>
                    /// </summary>
                    [NameInMap("Average")]
                    [Validation(Required=false)]
                    public double? Average { get; set; }

                    /// <summary>
                    /// <para>The GPU ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpn-1t1bxvp9az2pk****-gpu-0</para>
                    /// </summary>
                    [NameInMap("GpuId")]
                    [Validation(Required=false)]
                    public string GpuId { get; set; }

                    /// <summary>
                    /// <para>The maximum value. Unit: %.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the monitoring metric is bandwidth_package_usage_out or bandwidth_package_usage_in.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Maximum")]
                    [Validation(Required=false)]
                    public double? Maximum { get; set; }

                    /// <summary>
                    /// <para>The minimum value. Unit: %.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the monitoring metric is bandwidth_package_usage_out or bandwidth_package_usage_in.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>93.1</para>
                    /// </summary>
                    [NameInMap("Minimum")]
                    [Validation(Required=false)]
                    public double? Minimum { get; set; }

                    /// <summary>
                    /// <para>The statistical timestamp. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1548777660000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <para>The name of the monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The list of process monitoring metrics.</para>
                /// <remarks>
                /// <para>This parameter is returned when the monitoring metric is process_cpu or process_memory.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ProcessLastInfos")]
                [Validation(Required=false)]
                public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelListProcessLastInfos> ProcessLastInfos { get; set; }
                public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelListProcessLastInfos : TeaModel {
                    /// <summary>
                    /// <para>The CPU usage. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("CpuUsage")]
                    [Validation(Required=false)]
                    public double? CpuUsage { get; set; }

                    /// <summary>
                    /// <para>The memory usage. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("MemoryUsage")]
                    [Validation(Required=false)]
                    public double? MemoryUsage { get; set; }

                    /// <summary>
                    /// <para>The process name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.offerup</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The list of process IDs.</para>
                    /// </summary>
                    [NameInMap("ProcessIds")]
                    [Validation(Required=false)]
                    public List<int?> ProcessIds { get; set; }

                    /// <summary>
                    /// <para>The statistical timestamp. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1548777660000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The token for the next query. If a single query does not return all results, the returned NextToken is not empty. You can pass the returned NextToken in the next query to continue querying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B9E6946-0E2A-5D2B-B275-361DF81F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
