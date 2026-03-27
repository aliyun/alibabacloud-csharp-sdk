// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResponsePlanForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;2025-04-05T10:30:00Z&quot;</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Manual&quot;</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;P1-Critical-Response-Plan&quot;</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public PushingSetting PushingSetting { get; set; }

        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public RepeatNotifySetting RepeatNotifySetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;MANUAL&quot;</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ARMS&quot;</para>
        /// </summary>
        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Standard&quot;</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;2025-04-06T09:15:00Z&quot;</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;a1b2c3d4-e5f6-7890-1234-567890abcdef&quot;</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
