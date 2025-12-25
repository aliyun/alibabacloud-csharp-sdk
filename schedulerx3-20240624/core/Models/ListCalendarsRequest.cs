// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListCalendarsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>workday</para>
        /// </summary>
        [NameInMap("CalendarName")]
        [Validation(Required=false)]
        public string CalendarName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchCalendarDetail")]
        [Validation(Required=false)]
        public bool? FetchCalendarDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024</para>
        /// </summary>
        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
