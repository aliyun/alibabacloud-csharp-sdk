// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ReadSchedulerxCalendarRequest : TeaModel {
        /// <summary>
        /// <para>The calendar name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025workday</para>
        /// </summary>
        [NameInMap("CalendarName")]
        [Validation(Required=false)]
        public string CalendarName { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve calendar details. The default value is false.</para>
        /// <list type="bullet">
        /// <item><description>false: Returns only basic information without the detailed list of days for each month.</description></item>
        /// <item><description>true: Returns the detailed list of days for each month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchCalendarDetail")]
        [Validation(Required=false)]
        public bool? FetchCalendarDetail { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve system calendars. The default value is false.</para>
        /// <list type="bullet">
        /// <item><description>false: Returns only user-defined calendars.</description></item>
        /// <item><description>true: Returns both system calendars and user-defined calendars.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchSystemCalendar")]
        [Validation(Required=false)]
        public bool? FetchSystemCalendar { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on this call. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A token that specifies the starting position for retrieving the next page of data. You do not need to provide this parameter for the first request. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdYzT97YjSXWT8TQmxIAI5g=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025</para>
        /// </summary>
        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
