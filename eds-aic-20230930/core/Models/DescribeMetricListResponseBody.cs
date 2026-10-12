// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of instance monitoring results.</para>
        /// </summary>
        [NameInMap("MetricTotalModel")]
        [Validation(Required=false)]
        public List<DescribeMetricListResponseBodyMetricTotalModel> MetricTotalModel { get; set; }
        public class DescribeMetricListResponseBodyMetricTotalModel : TeaModel {
            /// <summary>
            /// <para>For instance-level monitoring, the cloud phone instance ID is returned. 
            /// &lt;props=&quot;china&quot;&gt;For matrix-level monitoring, the matrix ID is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyru4p****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-5hh4a31emkt6u****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of metric monitoring results.</para>
            /// </summary>
            [NameInMap("MetricModelList")]
            [Validation(Required=false)]
            public List<DescribeMetricListResponseBodyMetricTotalModelMetricModelList> MetricModelList { get; set; }
            public class DescribeMetricListResponseBodyMetricTotalModelMetricModelList : TeaModel {
                /// <summary>
                /// <para>The list of monitoring statistics data points.</para>
                /// </summary>
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public List<DescribeMetricListResponseBodyMetricTotalModelMetricModelListDataPoints> DataPoints { get; set; }
                public class DescribeMetricListResponseBodyMetricTotalModelMetricModelListDataPoints : TeaModel {
                    /// <summary>
                    /// <para>The average value. Unit: %.</para>
                    /// <remarks>
                    /// <para>If the metric is bandwidth_package_usage_out or bandwidth_package_usage_in, the unit is bps.</para>
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
                    /// <para>If the metric is bandwidth_package_usage_out or bandwidth_package_usage_in, the unit is bps.</para>
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
                    /// <para>If the metric is bandwidth_package_usage_out or bandwidth_package_usage_in, the unit is bps.</para>
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

                    /// <summary>
                    /// <para>The data value. Unit: %.</para>
                    /// <remarks>
                    /// <para>If the metric is bandwidth_package_usage_out or bandwidth_package_usage_in, the unit is bps.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tf-testacc-oos-parameter</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public double? Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The name of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Required</para>
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

        }

        /// <summary>
        /// <para>The token for the next query. If a query does not return all results, the returned NextToken is not empty. You can use the returned NextToken in subsequent queries to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
