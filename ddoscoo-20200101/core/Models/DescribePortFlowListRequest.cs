// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortFlowListRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. Specify the value as a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>The value must be on the minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583683200</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro and Anti-DDoS Premium instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The interval at which data is returned. Unit: seconds. The supported interval values vary based on the query time range (determined by <b>StartTime</b> and <b>EndTime</b>). Recommended settings:</para>
        /// <list type="bullet">
        /// <item><description>Query time range ≤ 1 hour: minimum interval of 60 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range &gt; 1 hour and ≤ 6 hours: minimum interval of 600 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range &gt; 6 hours and ≤ 24 hours: minimum interval of 1800 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range &gt; 24 hours and ≤ 7 days: minimum interval of 3600 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range &gt; 7 days and ≤ 15 days: minimum interval of 14400 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range &gt; 15 days: minimum interval of 43200 seconds, maximum not exceeding the query time range.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro and Anti-DDoS Premium instance belongs in Resource Management. By default, this parameter is empty, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the value as a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>The value must be on the minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
