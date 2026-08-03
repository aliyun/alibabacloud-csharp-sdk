// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetInsightsEventsCountRequest : TeaModel {
        /// <summary>
        /// <para>The date to query. The format is <c>yyyy-MM-dd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-07</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description><para>If Date, StartTime, and EndTime are all left empty, the system queries the number of events in the last 24 hours.</para>
        /// </description></item>
        /// <item><description><para>If Date is specified, the StartTime and EndTime parameters are ignored. The system queries the number of events on the specified date.</para>
        /// </description></item>
        /// <item><description><para>If Date is left empty and both StartTime and EndTime are specified, the system queries the number of events in the specified time range.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-07T06:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-01T02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
