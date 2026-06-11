// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MaintainWindowForView : TeaModel {
        /// <summary>
        /// <para>The time when the policy was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The effective time range.</para>
        /// </summary>
        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public MaintainWindowForViewEffectTimeRange EffectTimeRange { get; set; }
        public class MaintainWindowForViewEffectTimeRange : TeaModel {
            /// <summary>
            /// <para>The days of the week when the policy is effective.</para>
            /// </summary>
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            /// <summary>
            /// <para>The end time in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            /// <summary>
            /// <para>The start time in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>+08:00</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>The crontab expression.</para>
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
        /// <para>Indicates whether the policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The end time of the effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-26 12:02:01</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>The UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-12-312-31-23123</para>
        /// </summary>
        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试策略</para>
        /// </summary>
        [NameInMap("maintainWindowName")]
        [Validation(Required=false)]
        public string MaintainWindowName { get; set; }

        /// <summary>
        /// <para>The start time of the effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-26 10:02:01</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The last time the resource was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-07T02:19:05Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312***</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
