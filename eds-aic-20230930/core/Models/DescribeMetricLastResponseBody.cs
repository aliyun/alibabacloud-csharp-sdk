// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricLastResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("MetricTotalModel")]
        [Validation(Required=false)]
        public List<DescribeMetricLastResponseBodyMetricTotalModel> MetricTotalModel { get; set; }
        public class DescribeMetricLastResponseBodyMetricTotalModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyru4p****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            [NameInMap("MetricModelList")]
            [Validation(Required=false)]
            public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelList> MetricModelList { get; set; }
            public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelList : TeaModel {
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelListDataPoints> DataPoints { get; set; }
                public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelListDataPoints : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.52</para>
                    /// </summary>
                    [NameInMap("Average")]
                    [Validation(Required=false)]
                    public double? Average { get; set; }

                    [NameInMap("GpuId")]
                    [Validation(Required=false)]
                    public string GpuId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Maximum")]
                    [Validation(Required=false)]
                    public double? Maximum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>93.1</para>
                    /// </summary>
                    [NameInMap("Minimum")]
                    [Validation(Required=false)]
                    public double? Minimum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1548777660000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cpu_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("ProcessLastInfos")]
                [Validation(Required=false)]
                public List<DescribeMetricLastResponseBodyMetricTotalModelMetricModelListProcessLastInfos> ProcessLastInfos { get; set; }
                public class DescribeMetricLastResponseBodyMetricTotalModelMetricModelListProcessLastInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("CpuUsage")]
                    [Validation(Required=false)]
                    public double? CpuUsage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("MemoryUsage")]
                    [Validation(Required=false)]
                    public double? MemoryUsage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>com.offerup</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ProcessIds")]
                    [Validation(Required=false)]
                    public List<int?> ProcessIds { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B9E6946-0E2A-5D2B-B275-361DF81F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
