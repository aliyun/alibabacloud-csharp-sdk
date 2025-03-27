// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpDdosThresholdRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the asset.</para>
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
        /// <para>The type of the threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: traffic scrubbing threshold</description></item>
        /// <item><description><b>blackhole</b>: DDoS mitigation threshold</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("DdosType")]
        [Validation(Required=false)]
        public string DdosType { get; set; }

        /// <summary>
        /// <para>The ID of the asset.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/429562.html">DescribeInstanceIpAddress</a> operation to query the IDs of ECS instances, SLB instances, and EIPs within the current Alibaba Cloud account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i88rqjza51s****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the asset that is assigned a public IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: ECS instances.</description></item>
        /// <item><description><b>slb</b>: SLB instances.</description></item>
        /// <item><description><b>eip</b>: EIPs.</description></item>
        /// <item><description><b>ipv6</b>: IPv6 gateways.</description></item>
        /// <item><description><b>swas</b>: simple application servers.</description></item>
        /// <item><description><b>waf</b>: Web Application Firewall (WAF) instances of the Exclusive edition.</description></item>
        /// <item><description><b>ga_basic</b>: Global Accelerator (GA) instances.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

    }

}
