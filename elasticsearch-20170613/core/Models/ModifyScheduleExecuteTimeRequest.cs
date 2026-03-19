// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyScheduleExecuteTimeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eb7efbc90864a0***</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-30T08:45:00Z</para>
        /// </summary>
        [NameInMap("scheduleExecuteTime")]
        [Validation(Required=false)]
        public string ScheduleExecuteTime { get; set; }

    }

}
