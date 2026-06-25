// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListCalendarsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the calendar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workday</para>
        /// </summary>
        [NameInMap("CalendarName")]
        [Validation(Required=false)]
        public string CalendarName { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return calendar details. The default value is <c>false</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>false</c>: Does not return the detailed list of days for each month. Only basic information is returned.</para>
        /// </description></item>
        /// <item><description><para><c>true</c>: Returns the detailed list of days for each month.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchCalendarDetail")]
        [Validation(Required=false)]
        public bool? FetchCalendarDetail { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. Set this parameter to the <c>NextToken</c> value from the previous response. Omit this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024</para>
        /// </summary>
        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
