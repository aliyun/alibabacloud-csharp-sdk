// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetQosAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of Smart Access Gateway instances with configuration errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ErrorConfigSmartAGCount")]
        [Validation(Required=false)]
        public int? ErrorConfigSmartAGCount { get; set; }

        /// <summary>
        /// <para>The rate limiting rules with configuration errors in the QoS policy.</para>
        /// </summary>
        [NameInMap("QosCars")]
        [Validation(Required=false)]
        public List<GetQosAttributeResponseBodyQosCars> QosCars { get; set; }
        public class GetQosAttributeResponseBodyQosCars : TeaModel {
            /// <summary>
            /// <para>The rate limiting type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Absolute</b>: by bandwidth value.</description></item>
            /// <item><description><b>Percent</b>: by percentage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Absolute</para>
            /// </summary>
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBandwidthAbs")]
            [Validation(Required=false)]
            public int? MaxBandwidthAbs { get; set; }

            /// <summary>
            /// <para>The maximum bandwidth percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxBandwidthPercent")]
            [Validation(Required=false)]
            public int? MaxBandwidthPercent { get; set; }

            /// <summary>
            /// <para>The minimum bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinBandwidthAbs")]
            [Validation(Required=false)]
            public int? MinBandwidthAbs { get; set; }

            /// <summary>
            /// <para>The minimum bandwidth percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MinBandwidthPercent")]
            [Validation(Required=false)]
            public int? MinBandwidthPercent { get; set; }

            /// <summary>
            /// <para>The bandwidth type when rate limiting is based on percentage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CcnBandwidth</b>: Cloud Connect Network (CCN) bandwidth.</description></item>
            /// <item><description><b>InternetUpBandwidth</b>: Internet upstream bandwidth.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InternetUpBandwidth</para>
            /// </summary>
            [NameInMap("PercentSourceType")]
            [Validation(Required=false)]
            public string PercentSourceType { get; set; }

            /// <summary>
            /// <para>The priority of the rate limiting rule. Valid values: <b>1</b> to <b>3</b>. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The description of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosCarDescription")]
            [Validation(Required=false)]
            public string QosCarDescription { get; set; }

            /// <summary>
            /// <para>The ID of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qoscar-xir1apa8ayjp56ei****</para>
            /// </summary>
            [NameInMap("QosCarId")]
            [Validation(Required=false)]
            public string QosCarId { get; set; }

            /// <summary>
            /// <para>The name of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosCarName")]
            [Validation(Required=false)]
            public string QosCarName { get; set; }

        }

        /// <summary>
        /// <para>The description of the QoS policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QosDescription")]
        [Validation(Required=false)]
        public string QosDescription { get; set; }

        /// <summary>
        /// <para>The name of the QoS policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QosName")]
        [Validation(Required=false)]
        public string QosName { get; set; }

        /// <summary>
        /// <para>The list of 5-tuple rules for the QoS policy instance.</para>
        /// </summary>
        [NameInMap("QosPolicies")]
        [Validation(Required=false)]
        public List<GetQosAttributeResponseBodyQosPolicies> QosPolicies { get; set; }
        public class GetQosAttributeResponseBodyQosPolicies : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestCidr")]
            [Validation(Required=false)]
            public string DestCidr { get; set; }

            /// <summary>
            /// <para>The destination port range. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
            /// <para>Examples of the destination port range format:</para>
            /// <list type="bullet">
            /// <item><description><b>1/200</b>: indicates ports 1 to 200.</description></item>
            /// <item><description><b>80/80</b>: indicates port 80.</description></item>
            /// <item><description><b>-1/-1</b>: indicates that ports are not restricted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("DestPortRange")]
            [Validation(Required=false)]
            public string DestPortRange { get; set; }

            /// <summary>
            /// <para>The expiration time of the 5-tuple rules. The time is displayed in Beijing time. Format: UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-29T00:00:00+0800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The protocol type applied to the 5-tuple rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The priority of the rate limiting rule to which the 5-tuple rules belong. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The description of the 5-tuple rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosPolicieDescription")]
            [Validation(Required=false)]
            public string QosPolicieDescription { get; set; }

            /// <summary>
            /// <para>The name of the 5-tuple rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosPolicieName")]
            [Validation(Required=false)]
            public string QosPolicieName { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            /// <summary>
            /// <para>The source port range. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
            /// <para>Examples of the source port range format:</para>
            /// <list type="bullet">
            /// <item><description><b>1/200</b>: indicates ports 1 to 200.</description></item>
            /// <item><description><b>80/80</b>: indicates port 80.</description></item>
            /// <item><description><b>-1/-1</b>: indicates that ports are not restricted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The start of the effective period for the 5-tuple rules. The time is displayed in Beijing time. Format: UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-21T00:00:00+0800</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91058E01-1806-45D5-B305-19E4D0A5CE04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
