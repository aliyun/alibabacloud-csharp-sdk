// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateProbeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The destination domain name of the probe node.
        /// For ICMP and TCP Protocol Type probes, set this parameter to the IP address or domain name of the destination service. For HTTP Protocol Type probes, set this parameter to the URL of the destination service.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The number of packets sent per minute for the probe protocol.</para>
        /// <para>Valid values: <b>1</b> to <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required for ICMP Protocol Type probe tasks. Do not specify this parameter for other protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PacketNumber")]
        [Validation(Required=false)]
        public int? PacketNumber { get; set; }

        /// <summary>
        /// <para>The port number of the probe protocol.</para>
        /// <remarks>
        /// <para>This parameter is required for TCP Protocol Type probe tasks. Do not specify this parameter for other protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The source address for the private network probe.</para>
        /// <remarks>
        /// <para>This parameter is required for private network probe tasks.</para>
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
        /// <item><description><b>ICMP</b>.</description></item>
        /// <item><description><b>TCP</b>.</description></item>
        /// <item><description><b>HTTP</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Private network probes support only the ICMP and TCP protocols.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Smart Access Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-asdfz6ac74oj5v****</para>
        /// </summary>
        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        /// <summary>
        /// <para>The serial number of the Smart Access Gateway device.</para>
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

        /// <summary>
        /// <para>The type of the probe task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: public network probe.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: private network probe.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
