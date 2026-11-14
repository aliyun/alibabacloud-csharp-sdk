// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class WarmPoolScheduledPolicy : TeaModel {
        /// <summary>
        /// <para>The end time when the rule expires, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the scheduled rule. It must be unique within the same warm pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily-scale</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The cron expression for the scheduled rule, in the cron (second minute hour day month week) format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cron(0 0 0 * * *)</para>
        /// </summary>
        [NameInMap("scheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// <para>The start time when the rule takes effect, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The target number of ready sandboxes after the rule is triggered. The value can be 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        /// <summary>
        /// <para>The IANA time zone used to execute the scheduled rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
