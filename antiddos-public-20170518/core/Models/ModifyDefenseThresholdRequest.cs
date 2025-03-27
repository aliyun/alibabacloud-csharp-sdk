// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class ModifyDefenseThresholdRequest : TeaModel {
        /// <summary>
        /// <para>The traffic scrubbing threshold. Unit: Mbit/s. The traffic scrubbing threshold cannot exceed the peak inbound or outbound Internet traffic, whichever is larger, of the asset. When you modify Bps, Pps is required. Otherwise, Bps does not take effect.</para>
        /// <para>You can use the monitoring tool that is provided by the asset to query the Internet traffic of the asset:</para>
        /// <list type="bullet">
        /// <item><description>If the asset is an ECS instance, see <a href="https://help.aliyun.com/document_detail/25482.html">View instance monitoring information</a>.</description></item>
        /// <item><description>If the asset is an SLB instance, see <a href="https://help.aliyun.com/document_detail/85982.html">View monitoring data</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public int? Bps { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the asset for which you want to change the scrubbing thresholds.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/353250.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the asset.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/354191.html">DescribeInstance</a> operation to query the IDs of ECS instances, SLB instances, and EIPs within the current Alibaba Cloud account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6idy3c57psf7vu****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>slb</b>: a Server Load Balancer (SLB) instance.</description></item>
        /// <item><description><b>eip</b>: an elastic IP address (EIP).</description></item>
        /// <item><description><b>ipv6</b>: an IPv6 gateway.</description></item>
        /// <item><description><b>swas</b>: a simple application server.</description></item>
        /// <item><description><b>waf</b>: a Web Application Firewall (WAF) instance of the Exclusive edition.</description></item>
        /// <item><description><b>ga_basic</b>: a Global Accelerator (GA) instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The IP address of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically adjust the scrubbing threshold based on the traffic load on the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatically adjusts the scrubbing thresholds. You do not need to configure the <b>Bps</b> and <b>Pps</b> parameters.</description></item>
        /// <item><description><b>false</b>: The scrubbing threshold is not automatically adjusted. You must configure the <b>Bps</b> and <b>Pps</b> parameters.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsAuto")]
        [Validation(Required=false)]
        public bool? IsAuto { get; set; }

        /// <summary>
        /// <para>The packet scrubbing threshold. Unit: packets per second (PPS). When you modify Pps, Bps is required. Otherwise, Pps does not take effect.</para>
        /// <para>The packet scrubbing threshold cannot exceed the peak number of inbound or outbound packets, whichever is larger, of the asset. You can use the monitoring tool that is provided by the asset to query the number of packets of the asset:</para>
        /// <list type="bullet">
        /// <item><description>If the asset is an ECS instance, see <a href="https://help.aliyun.com/document_detail/25482.html">View instance monitoring information</a>.</description></item>
        /// <item><description>If the asset is an SLB instance, see <a href="https://help.aliyun.com/document_detail/85982.html">View monitoring data</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>70000</para>
        /// </summary>
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public int? Pps { get; set; }

    }

}
