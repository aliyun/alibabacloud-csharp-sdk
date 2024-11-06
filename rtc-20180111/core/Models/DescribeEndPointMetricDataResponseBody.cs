// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointMetricDataResponseBody : TeaModel {
        [NameInMap("PubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodyPubMetrics> PubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodyPubMetrics : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodyPubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodyPubMetricsNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1548670257</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>230100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIDEO_STUCK_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodySubMetrics> SubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodySubMetrics : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodySubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodySubMetricsNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1548670257</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>230100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIDEO_STUCK_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
