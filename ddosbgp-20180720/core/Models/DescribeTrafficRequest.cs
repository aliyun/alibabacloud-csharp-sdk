// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <para>If you do not set this parameter, the current time is used as the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1563445054</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The type of traffic statistics to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>max</b>: the peak traffic within the statistical interval.</description></item>
        /// <item><description><b>avg</b>: the average traffic within the statistical interval.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// <para>If the instance specified here is used for traffic diversion, you must set the <b>Interval</b> request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-n6w203qg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time interval for traffic statistics. Unit: seconds. This parameter specifies the length of each interval for which traffic data is aggregated. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The assets that are assigned public IP addresses to query. If you do not specify this parameter in Settings, the traffic statistics of all assets that are assigned public IP addresses protected by the Anti-DDoS Origin instance are queried.</para>
        /// <remarks>
        /// <para>The assets that are assigned public IP addresses must have been added as protected objects of the Anti-DDoS Origin instance. You can invoke <a href="https://help.aliyun.com/document_detail/118701.html">DescribePackIpList</a> to query all protected objects of the Anti-DDoS Origin instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>39.XX.XX.96</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The CIDR block used for traffic diversion to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("Ipnet")]
        [Validation(Required=false)]
        public string Ipnet { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query all region IDs supported by Anti-DDoS Origin.</para>
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
        /// <para>If you do not set this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify a UNIX timestamp. Unit: seconds.</para>
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
