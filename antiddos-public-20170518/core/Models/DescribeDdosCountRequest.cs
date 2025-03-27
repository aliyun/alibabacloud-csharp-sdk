// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCountRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the asset to query.</para>
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
        /// <para>The type of the asset to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: Elastic Compute Service (ECS) instances.</description></item>
        /// <item><description><b>slb</b>: Server Load Balancer (SLB) instances.</description></item>
        /// <item><description><b>eip</b>: elastic IP addresses (EIPs).</description></item>
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

    }

}
