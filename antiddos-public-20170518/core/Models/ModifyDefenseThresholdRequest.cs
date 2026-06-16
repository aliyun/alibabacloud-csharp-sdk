// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class ModifyDefenseThresholdRequest : TeaModel {
        /// <summary>
        /// <para>The scrubbing threshold for traffic in Mbps. This value cannot exceed the peak public network traffic of the instance. If you specify Bps, you must also specify Pps. Otherwise, the change does not take effect.</para>
        /// <para>Use the monitoring tools of your instance to query its public network traffic:</para>
        /// <list type="bullet">
        /// <item><description><para>For an ECS instance, see <a href="https://help.aliyun.com/document_detail/25482.html">View instance monitoring information</a>.</para>
        /// </description></item>
        /// <item><description><para>For an SLB instance, see <a href="https://help.aliyun.com/document_detail/85982.html">View monitoring data</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For an EIP instance, see <a href="https://help.aliyun.com/document_detail/85354.html">View monitoring data</a>.</description></item>
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
        /// <para>The region ID of the asset that is assigned a public IP address.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/353250.html">DescribeRegions</a> to query all region IDs.</para>
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
        /// <para>The instance ID of the asset that is assigned a public IP address.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/354191.html">DescribeInstance</a> to query the IDs of the ECS, SLB, and EIP instances that belong to your Alibaba Cloud account.</para>
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
        /// <para>The instance type of the asset that is assigned a public IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS) instance.</para>
        /// </description></item>
        /// <item><description><para><b>slb</b>: Server Load Balancer (SLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>eip</b>: Elastic IP Address (EIP) instance.</para>
        /// </description></item>
        /// <item><description><para><b>ipv6</b>: IPv6 Gateway instance.</para>
        /// </description></item>
        /// <item><description><para><b>swas</b>: simple application server instance.</para>
        /// </description></item>
        /// <item><description><para><b>waf</b>: dedicated Web Application Firewall (WAF) instance.</para>
        /// </description></item>
        /// <item><description><para><b>ga_basic</b>: basic Global Accelerator (GA) instance.</para>
        /// </description></item>
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
        /// <para>The public IP address of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically adjust the scrubbing threshold based on the traffic loads of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The scrubbing threshold is automatically adjusted. You do not need to set the <b>Bps</b> and <b>Pps</b> parameters.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The scrubbing threshold is not automatically adjusted. You must set the <b>Bps</b> and <b>Pps</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsAuto")]
        [Validation(Required=false)]
        public bool? IsAuto { get; set; }

        /// <summary>
        /// <para>The scrubbing threshold for packets per second (pps). This value cannot exceed the peak packet traffic of the instance. If you specify Pps, you must also specify Bps. Otherwise, the change does not take effect.</para>
        /// <para>Use the monitoring tools of your instance to query its packet traffic:</para>
        /// <list type="bullet">
        /// <item><description><para>For an ECS instance, see <a href="https://help.aliyun.com/document_detail/25482.html">View instance monitoring information</a>.</para>
        /// </description></item>
        /// <item><description><para>For an SLB instance, see <a href="https://help.aliyun.com/document_detail/85982.html">View monitoring data</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For an EIP instance, see <a href="https://help.aliyun.com/document_detail/85354.html">View monitoring data</a>.</description></item>
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
