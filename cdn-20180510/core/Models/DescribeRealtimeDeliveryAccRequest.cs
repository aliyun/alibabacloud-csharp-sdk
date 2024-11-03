// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRealtimeDeliveryAccRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-10-20T05:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data entries. Unit: seconds. The value varies based on the values of the <b>StartTime</b> and <b>EndTime</b> parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the time span between StartTime and EndTime is less than 3 days, valid values are <b>300</b>, <b>3600</b>, and <b>86400</b>. Default value: <b>300</b>.</description></item>
        /// <item><description>If the time span between StartTime and EndTime is greater than or equal to 3 days and less than 31 days, valid values are <b>3600</b> and <b>86400</b>. Default value: <b>3600</b>.</description></item>
        /// <item><description>If the time span between StartTime and EndTime is 31 days or longer, the valid value is <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Logstore that stores log data. If you do leave this parameter empty, real-time log deliveries of all Logstores are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogStore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for real-time log delivery. If you do leave this parameter empty, real-time log deliveries of all projects are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-10-20T04:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
