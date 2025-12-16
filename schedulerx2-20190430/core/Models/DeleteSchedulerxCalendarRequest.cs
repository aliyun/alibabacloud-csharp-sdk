// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DeleteSchedulerxCalendarRequest : TeaModel {
        /// <summary>
        /// <para>The calendar name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025workday</para>
        /// </summary>
        [NameInMap("CalendarName")]
        [Validation(Required=false)]
        public string CalendarName { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025</para>
        /// </summary>
        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
