// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsTimerRequest : TeaModel {
        /// <summary>
        /// <para>The scheduling type of the task. Valid values: <c>Daily</c> and <c>Hourly</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduled task is stopped.</para>
        /// </summary>
        [NameInMap("stopped")]
        [Validation(Required=false)]
        public bool? Stopped { get; set; }

        /// <summary>
        /// <para>The execution time of the scheduled task. If <c>scheduleType</c> is set to <c>Daily</c>, specify the time in the HH:mm format. If <c>scheduleType</c> is set to <c>Hourly</c>, specify the minute in the mm format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-20</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
