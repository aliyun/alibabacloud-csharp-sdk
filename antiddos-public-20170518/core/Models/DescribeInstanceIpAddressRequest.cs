// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeInstanceIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The DDoS mitigation status of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: queries assets for which traffic scrubbing is performed.</description></item>
        /// <item><description><b>blackhole</b>: queries assets for which blackhole filtering is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DdosStatus")]
        [Validation(Required=false)]
        public string DdosStatus { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the asset is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cb6x80tfgocid****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>launch-advisor-2021****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
