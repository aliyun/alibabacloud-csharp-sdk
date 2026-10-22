// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">describedbclusters</a> operation to query the details of all clusters under your account, such as the cluster ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-23T01:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies the time granularity of the data to be retrieved. Valid values: <b>60</b> (minutes) and <b>3600</b> (hours).</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>Interval</b> to <b>60</b>, you can query data generated within the last month. The maximum time range for a single query is 7 days.</description></item>
        /// <item><description>If you set <b>Interval</b> to <b>3600</b>, you can query data generated within the last month. The maximum time range for a single query is 7 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the monitoring metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBAIModelCall</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-17T02:18:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
