// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpdateProbeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that is probed by the task.</para>
        /// <para>If the protocol of the probe task is ICMP or TCP, set the value to the IP address or domain name of the service that you want to probe. If the protocol of the probe task is HTTP, set the value to the URL of the service that you want to probe.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the probe task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The number of probe packets transmitted by the probe task per minute.</para>
        /// <para>Valid values: <b>1</b> to <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required if the protocol of the probe task is ICMP. Ignore this parameter if the protocol of the probe task is not ICMP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PacketNumber")]
        [Validation(Required=false)]
        public int? PacketNumber { get; set; }

        /// <summary>
        /// <para>The port that is probed by the task.</para>
        /// <remarks>
        /// <para>This parameter is required if the protocol of the probe task is TCP. Ignore this parameter if the protocol of the probe task is not TCP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The ID of the probe task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>probe-****</para>
        /// </summary>
        [NameInMap("ProbeTaskId")]
        [Validation(Required=false)]
        public string ProbeTaskId { get; set; }

        /// <summary>
        /// <para>The source address of the probe task.</para>
        /// <remarks>
        /// <para>This parameter is required if the task probes private networks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1</para>
        /// </summary>
        [NameInMap("ProbeTaskSourceAddress")]
        [Validation(Required=false)]
        public string ProbeTaskSourceAddress { get; set; }

        /// <summary>
        /// <para>The protocol of the probe task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ICMP</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Tasks that probe private networks support only ICMP and TCP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-****</para>
        /// </summary>
        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag****</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <para>The name of the probe task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ping</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
