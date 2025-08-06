// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRealtimeDeliveryAccRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The end time must be later than the start time. The interval between the start time and the end time cannot exceed a year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data entries. Unit: seconds. Valid values: 300, 3600, and 86400.</para>
        /// <para>The default time granularity varies based on the interval between the start time and end time that you specify. If you set the interval to a value within (0,3] days, the default time granularity is 300 seconds. If you set the interval to a value within (3,30] days, the default time granularity is 3,600 seconds. If you set the interval to a value greater than 30 days, the default time granularity is 86,400 seconds. The default value is used if you specify an invalid value for this parameter or leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Logstore to which log entries are delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod-log-store</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for real-time log delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod-logs</para>
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
