// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricTopResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("MetricTotalModel")]
        [Validation(Required=false)]
        public List<DescribeMetricTopResponseBodyMetricTotalModel> MetricTotalModel { get; set; }
        public class DescribeMetricTopResponseBodyMetricTotalModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyru4p****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>np-5hh4a31emkt6u****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MetricModelList")]
            [Validation(Required=false)]
            public List<DescribeMetricTopResponseBodyMetricTotalModelMetricModelList> MetricModelList { get; set; }
            public class DescribeMetricTopResponseBodyMetricTotalModelMetricModelList : TeaModel {
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public List<DescribeMetricTopResponseBodyMetricTotalModelMetricModelListDataPoints> DataPoints { get; set; }
                public class DescribeMetricTopResponseBodyMetricTotalModelMetricModelListDataPoints : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.52</para>
                    /// </summary>
                    [NameInMap("Average")]
                    [Validation(Required=false)]
                    public double? Average { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>acp-fkuit0cmyru4p****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

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

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public string Properties { get; set; }

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
                /// <para>instance_in_traffic</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

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
        /// <para>4610632D-D661-5982-B3D7-5D3FD183F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
