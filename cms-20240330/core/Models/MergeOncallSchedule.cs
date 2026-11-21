// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeOncallSchedule : TeaModel {
        /// <summary>
        /// <para>The extended details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;oncallScheduleId&quot;: &quot;testId&quot;,
        ///   &quot;oncallScheduleName&quot;: &quot;testName&quot;,
        ///   &quot;rotations&quot;: [
        ///     {
        ///       &quot;activeDays&quot;: [
        ///         1
        ///       ],
        ///       &quot;contacts&quot;: [
        ///         &quot;testId&quot;
        ///       ],
        ///       &quot;rotationEndTime&quot;: &quot;24:00&quot;,
        ///       &quot;rotationName&quot;: &quot;testName&quot;,
        ///       &quot;rotationStartTime&quot;: &quot;00:00&quot;,
        ///       &quot;shiftRecurrenceFrequency&quot;: &quot;WEEKLY&quot;,
        ///       &quot;startDate&quot;: &quot;2024-01-01&quot;,
        ///       &quot;timeZone&quot;: &quot;Asia/Shanghai&quot;,
        ///       &quot;shiftLength&quot;: 3
        ///     }
        ///   ],
        ///   &quot;shiftRobotId&quot;: &quot;testId&quot;,
        ///   &quot;substitudes&quot;: [
        ///     {
        ///       &quot;startTime&quot;: &quot;2024-10-10 09:00&quot;,
        ///       &quot;endTime&quot;: &quot;2024-10-15 18:00&quot;,
        ///       &quot;replacedContactId&quot;: &quot;testId&quot;,
        ///       &quot;contactId&quot;: &quot;testId&quot;
        ///     }
        ///   ],
        ///   &quot;workspace&quot;: &quot;default-cms-5884500827389836-cn-hangzhou&quot;
        /// }</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The name of the schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
