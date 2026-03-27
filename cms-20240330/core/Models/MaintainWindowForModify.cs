// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MaintainWindowForModify : TeaModel {
        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Effective time range.</para>
        /// </summary>
        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public MaintainWindowForModifyEffectTimeRange EffectTimeRange { get; set; }
        public class MaintainWindowForModifyEffectTimeRange : TeaModel {
            /// <summary>
            /// <para>Effective days (Monday to Sunday).</para>
            /// </summary>
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            /// <summary>
            /// <para>End time (in minutes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            /// <summary>
            /// <para>Start time (in minutes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            /// <summary>
            /// <para>Time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>+08:00</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>Crontab expression.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>14-18 ? * *</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("effective")]
        [Validation(Required=false)]
        public string Effective { get; set; }

        /// <summary>
        /// <para>Effective end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-05 09:30:40</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Filtering conditions.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test strategy</para>
        /// </summary>
        [NameInMap("maintainWindowName")]
        [Validation(Required=false)]
        public string MaintainWindowName { get; set; }

        /// <summary>
        /// <para>Effective start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-11 07:55:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
