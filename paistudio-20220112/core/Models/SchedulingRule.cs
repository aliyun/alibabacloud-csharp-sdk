// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SchedulingRule : TeaModel {
        /// <summary>
        /// <para>The cron tab. Only the minute, hour, day, month, and week fields are currently supported. Second-level configurations are discarded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 * * 7</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("CronTab")]
        [Validation(Required=false)]
        public string CronTab { get; set; }

        /// <summary>
        /// <para>The stop time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-22T00:00:00Z</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EndAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is executed only once.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExecuteOnce")]
        [Validation(Required=false)]
        public bool? ExecuteOnce { get; set; }

        /// <summary>
        /// <para>The start time of the effective period for the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("StartAt")]
        [Validation(Required=false)]
        public string StartAt { get; set; }

    }

}
