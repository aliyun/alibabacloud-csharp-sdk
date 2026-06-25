// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricTopResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The instance monitoring data.</para>
        /// </summary>
        [NameInMap("MetricTotalModel")]
        [Validation(Required=false)]
        public List<DescribeMetricTopResponseBodyMetricTotalModel> MetricTotalModel { get; set; }
        public class DescribeMetricTopResponseBodyMetricTotalModel : TeaModel {
            /// <summary>
            /// <para>For instance-level monitoring, this is the cloud phone instance ID.
            /// &lt;props=&quot;china&quot;&gt;For matrix-level monitoring, this is the matrix ID.</para>
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
            /// <para>The monitoring data of metrics.</para>
            /// </summary>
            [NameInMap("MetricModelList")]
            [Validation(Required=false)]
            public List<DescribeMetricTopResponseBodyMetricTotalModelMetricModelList> MetricModelList { get; set; }
            public class DescribeMetricTopResponseBodyMetricTotalModelMetricModelList : TeaModel {
                /// <summary>
                /// <para>The monitoring data points.</para>
                /// </summary>
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public List<DescribeMetricTopResponseBodyMetricTotalModelMetricModelListDataPoints> DataPoints { get; set; }
                public class DescribeMetricTopResponseBodyMetricTotalModelMetricModelListDataPoints : TeaModel {
                    /// <summary>
                    /// <para>The average value. Unit: %.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the metric is \<c>instance_in_traffic\\</c> or \<c>instance_out_traffic\\</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.52</para>
                    /// </summary>
                    [NameInMap("Average")]
                    [Validation(Required=false)]
                    public double? Average { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acp-fkuit0cmyru4p****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The maximum value. Unit: %.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the metric is \<c>instance_in_traffic\\</c> or \<c>instance_out_traffic\\</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Maximum")]
                    [Validation(Required=false)]
                    public double? Maximum { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// <remarks>
                    /// <para>The unit is bps when the metric is \<c>instance_in_traffic\\</c> or \<c>instance_out_traffic\\</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>93.1</para>
                    /// </summary>
                    [NameInMap("Minimum")]
                    [Validation(Required=false)]
                    public double? Minimum { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloudPhone-****</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The properties.</para>
                    /// <remarks>
                    /// <para>A JSON string that contains the extension properties.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;IP&quot;:&quot;192.168.<em>.</em>**&quot;}</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public string Properties { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the data point. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1548777660000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_in_traffic</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

            }

        }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If the results are not fully returned in a single query, this parameter is not empty. You can use this token in a subsequent query to retrieve the next page of results.</para>
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
        /// <para>4610632D-D661-5982-B3D7-5D3FD183F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
