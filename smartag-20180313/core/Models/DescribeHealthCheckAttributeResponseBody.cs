// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeHealthCheckAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the health check instance was created. This value is a UNIX timestamp.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586759657000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the health check instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc-123</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination IP address of the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("DstIpAddr")]
        [Validation(Required=false)]
        public string DstIpAddr { get; set; }

        /// <summary>
        /// <para>The destination port of the health check instance.</para>
        /// <remarks>
        /// <para> This feature is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1223</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        /// <summary>
        /// <para>The maximum number of failed probes before the health check is declared failed.</para>
        /// <para>Valid values: <b>1</b> to <b>15</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FailCountThreshold")]
        [Validation(Required=false)]
        public int? FailCountThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the health check instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc-1k4ucuq77b56x4****</para>
        /// </summary>
        [NameInMap("HcInstanceId")]
        [Validation(Required=false)]
        public string HcInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the health check instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bvt-test-03****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of probes performed per health check.</para>
        /// <para>Valid values: <b>1</b> to <b>20</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProbeCount")]
        [Validation(Required=false)]
        public int? ProbeCount { get; set; }

        /// <summary>
        /// <para>The time interval at which probes are performed. The next probe does not start before the current one is complete.</para>
        /// <para>Valid values: <b>1000</b> to <b>60000</b>.</para>
        /// <para>Default value: <b>2000</b>.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("ProbeInterval")]
        [Validation(Required=false)]
        public int? ProbeInterval { get; set; }

        /// <summary>
        /// <para>The timeout period of the probe.</para>
        /// <para>Valid values: <b>10</b> to <b>30000</b>.</para>
        /// <para>Default value: <b>1000</b>.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProbeTimeout")]
        [Validation(Required=false)]
        public int? ProbeTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DDA08B78-5634-4A83-94E4-5C58FD7EBA19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of times that the maximum RTT is exceeded before an alert is triggered.</para>
        /// <para>Valid values: <b>1</b> to <b>15</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RttFailThreshold")]
        [Validation(Required=false)]
        public int? RttFailThreshold { get; set; }

        /// <summary>
        /// <para>The maximum round-trip time (RTT).</para>
        /// <para>Value values: <b>-1</b> and <b>1</b> to <b>5000</b>.</para>
        /// <para>Default value: <b>-1</b>. This value indicates that the RTT threshold is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("RttThreshold")]
        [Validation(Required=false)]
        public int? RttThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-1um5x5nwhilymw****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The source IP address of the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.1</para>
        /// </summary>
        [NameInMap("SrcIpAddr")]
        [Validation(Required=false)]
        public string SrcIpAddr { get; set; }

        /// <summary>
        /// <para>The source port of the health check instance.</para>
        /// <remarks>
        /// <para> This feature is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2334</para>
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// <para>The type of packets used in the health check.</para>
        /// <para>Only <b>ICMP_ECHO</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP_ECHO</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
