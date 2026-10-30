// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The paging Settings for the current page number in a paged query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp in milliseconds. Operation logs generated before this time are queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640880000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-n6w1r7nz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: attach an IP address</description></item>
        /// <item><description><b>4</b>: unbind an IP address</description></item>
        /// <item><description><b>5</b>: decrease the quota</description></item>
        /// <item><description><b>6</b>: deactivate blackhole filtering</description></item>
        /// <item><description><b>7</b>: Reset quota on blackhole filtering deactivation</description></item>
        /// <item><description><b>8</b>: recover burstable protection</description></item>
        /// <item><description><b>9</b>: add an Asset group</description></item>
        /// <item><description><b>10</b>: delete an Asset group</description></item>
        /// <item><description><b>11</b>: enable daily 95th percentile bandwidth</description></item>
        /// <item><description><b>12</b>: enable monthly 95th percentile bandwidth</description></item>
        /// <item><description><b>13</b>: periodically switch between daily and monthly 95th percentile bandwidth patterns</description></item>
        /// <item><description><b>14</b>: shutdown daily 95th percentile bandwidth</description></item>
        /// <item><description><b>15</b>: shutdown monthly 95th percentile bandwidth</description></item>
        /// <item><description><b>16</b>: shutdown burstable clean bandwidth due to overdue payments</description></item>
        /// <item><description><b>17</b>: shutdown burstable clean bandwidth when they expire</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OpAction")]
        [Validation(Required=false)]
        public int? OpAction { get; set; }

        /// <summary>
        /// <para>The field by which to sort the operation logs. Set the value to <b>opdate</b>, which indicates that the operation logs are sorted by operation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opdate</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort order of the operation logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order</description></item>
        /// <item><description><b>DESC</b>: descending order</description></item>
        /// </list>
        /// <para>Default value: <b>DESC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderDir")]
        [Validation(Required=false)]
        public string OrderDir { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of Operation logs per page in a paged query. Maximum value: 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the IDs of all regions supported by Anti-DDoS Origin.</para>
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
        /// <para>If you do not specify this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp in milliseconds. Operation logs generated after this time are queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1609430400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
