// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class DataScheduledTaskInfoBySessionIdValue : TeaModel {
        /// <summary>
        /// <para>The time when the overview was generated, in UTC ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-17T12:00:00Z</para>
        /// </summary>
        [NameInMap("AsOf")]
        [Validation(Required=false)]
        public string AsOf { get; set; }

        /// <summary>
        /// <para>The number of associated tasks in the ENABLED status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnabledCount")]
        [Validation(Required=false)]
        public long? EnabledCount { get; set; }

        /// <summary>
        /// <para>Indicates whether the current session has associated scheduled tasks that are in the ENABLED, PAUSED, or NEEDS_AUTH status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasScheduledTask")]
        [Validation(Required=false)]
        public bool? HasScheduledTask { get; set; }

        /// <summary>
        /// <para>The total number of associated tasks. Only tasks in the ENABLED, PAUSED, or NEEDS_AUTH status are counted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public long? TaskCount { get; set; }

    }

}
