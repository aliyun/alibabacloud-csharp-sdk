// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalAgentSkillGroupReportRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The end time. This is a UNIX timestamp in milliseconds. This parameter is not required. The default value is the current time. If Interval is set to Daily, the maximum interval between StartTime and EndTime is 180 days. If Interval is set to Hourly, the maximum interval is 10 days. The statistics are measured in hours and rounded up to the nearest hour. This is an open interval. For example, if the start time is 11:12:20 and the end time is 11:45:50, the aligned time range for the input parameters is [11:00:00, 12:00:00), which means greater than or equal to 11:00 and less than 12:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1558443508000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of interval-based statistics. This parameter is not required. The default value is Daily (summarized by day).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skg-default@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <para>The start timestamp. The default value is 00:00 on the current day. The statistics are measured in hours and rounded down to the nearest hour. This is a closed interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532448000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
