// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobInstanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of all monitoring metrics that match the filter condition.</para>
        /// </summary>
        [NameInMap("InstanceMetrics")]
        [Validation(Required=false)]
        public List<ListTrainingJobInstanceMetricsResponseBodyInstanceMetrics> InstanceMetrics { get; set; }
        public class ListTrainingJobInstanceMetricsResponseBodyInstanceMetrics : TeaModel {
            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trainkxen7qjyg6y-master-0</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>List of instance monitoring metrics.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListTrainingJobInstanceMetricsResponseBodyInstanceMetricsMetrics> Metrics { get; set; }
            public class ListTrainingJobInstanceMetricsResponseBodyInstanceMetricsMetrics : TeaModel {
                /// <summary>
                /// <para>UTC time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>Metric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>Node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trains930928remn-master-0</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F082BD0D-21E1-5F9B-81A0-AB07485B03CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
