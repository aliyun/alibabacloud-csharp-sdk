// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time. Operation logs that were generated before this time are queried.**** The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640880000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-n6w1r7nz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: Add an IP address to the instance.</description></item>
        /// <item><description><b>4</b>: Remove an IP address from the instance.</description></item>
        /// <item><description><b>5</b>: Downgrade the instance.</description></item>
        /// <item><description><b>6</b>: Deactivate blackhole filtering.</description></item>
        /// <item><description><b>7</b>: Reset the number of times that you can deactivate blackhole filtering.</description></item>
        /// <item><description><b>8</b>: Restore the mitigation capability.</description></item>
        /// <item><description><b>9</b>: Add an asset group.</description></item>
        /// <item><description><b>10</b>: Remove an asset group.</description></item>
        /// <item><description><b>11</b>: Enable the metering method of daily 95th percentile for the burstable clean bandwidth feature.</description></item>
        /// <item><description><b>12</b>: Enable the metering method of monthly 95th percentile for the burstable clean bandwidth feature.</description></item>
        /// <item><description><b>13</b>: Periodically switch between the metering methods of daily 95th percentile and monthly 95th percentile for the burstable clean bandwidth feature.</description></item>
        /// <item><description><b>14</b>: Disable the metering method of daily 95th percentile for the burstable clean bandwidth feature.</description></item>
        /// <item><description><b>15</b>: Disable the metering method of monthly 95th percentile for the burstable clean bandwidth feature.</description></item>
        /// <item><description><b>16</b>: Disable burstable clean bandwidth due to overdue payments.</description></item>
        /// <item><description><b>17</b>: Disable burstable clean bandwidth due to instance expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OpAction")]
        [Validation(Required=false)]
        public int? OpAction { get; set; }

        /// <summary>
        /// <para>The sorting method of operation logs. Set the value to <b>opdate</b>, which indicates sorting based on the operation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opdate</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort order of operation logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: the ascending order.</description></item>
        /// <item><description><b>DESC</b>: the descending order.</description></item>
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
        /// <para>The number of entries per page. Maximum value: 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time. Operation logs that were generated after this time are queried.**** The value is a UNIX timestamp. Unit: milliseconds.</para>
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
