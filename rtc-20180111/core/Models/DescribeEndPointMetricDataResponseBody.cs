// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The metric data of the publisher.</para>
        /// </summary>
        [NameInMap("PubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodyPubMetrics> PubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodyPubMetrics : TeaModel {
            /// <summary>
            /// <para>The list of coordinate points.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodyPubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodyPubMetricsNodes : TeaModel {
                /// <summary>
                /// <para>The extended properties.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>The x-axis coordinate in the publisher metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548670257</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the publisher metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>230100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>The metric type corresponding to the Metrics request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIDEO_STUCK_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metric data of the subscriber.</para>
        /// </summary>
        [NameInMap("SubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodySubMetrics> SubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodySubMetrics : TeaModel {
            /// <summary>
            /// <para>The list of coordinate points for the subscriber metric trends chart.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodySubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodySubMetricsNodes : TeaModel {
                /// <summary>
                /// <para>The extended properties.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>The x-axis coordinate in the subscriber metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548670257</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the subscriber metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>230100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>The metric type corresponding to the Metrics request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIDEO_STUCK_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
