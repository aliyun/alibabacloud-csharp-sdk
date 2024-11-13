// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>If you do not specify this parameter, the current system time is used as the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1563445054</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The type of the traffic statistics to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>max</b>: the peak traffic within the specified interval</description></item>
        /// <item><description><b>avg</b>: the average traffic within the specified interval</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// <para>If you specify an on-demand instance, you must configure the <b>Interval</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-n6w203qg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interval at which the traffic statistics are calculated. Unit: seconds. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The public IP address of the asset to query. If you do not specify this parameter, the traffic statistics of all public IP addresses that are protected by the Anti-DDoS Origin instance are queried.</para>
        /// <remarks>
        /// <para> The public IP address must be a protected object of the Anti-DDoS Origin instance. You can call the <a href="https://help.aliyun.com/document_detail/118701.html">DescribePackIpList</a> operation to query all protected objects of the Anti-DDoS Origin instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>39.XX.XX.96</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The Classless Inter-Domain Routing (CIDR) block of the on-demand instance that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("Ipnet")]
        [Validation(Required=false)]
        public string Ipnet { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Anti-DDoS Origin instance resides.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619798400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
