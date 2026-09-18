// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsTimerRequest : TeaModel {
        /// <summary>
        /// <para>The scheduling type of the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>Indicates whether the scheduled task is stopped.</para>
        /// </summary>
        [NameInMap("stopped")]
        [Validation(Required=false)]
        public bool? Stopped { get; set; }

        /// <summary>
        /// <para>The tables to exclude when type is set to Database.</para>
        /// </summary>
        [NameInMap("tableBlackList")]
        [Validation(Required=false)]
        public List<string> TableBlackList { get; set; }

        /// <summary>
        /// <para>The tables to migrate when type is set to Database.</para>
        /// </summary>
        [NameInMap("tableWhiteList")]
        [Validation(Required=false)]
        public List<string> TableWhiteList { get; set; }

        /// <summary>
        /// <para>The scheduling time of the scheduled task. If scheduleType is set to Daily, the value is in the HH:MM format. If scheduleType is set to Hourly, the value is in the MM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-20</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
