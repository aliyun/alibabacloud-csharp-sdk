// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResponsePlanForModify : TeaModel {
        /// <summary>
        /// <para>The auto-recovery time in seconds when no events occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the response plan is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The list of escalation plan IDs.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The lifecycle mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The push settings.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public PushingSetting PushingSetting { get; set; }

        /// <summary>
        /// <para>The repeat notification configuration.</para>
        /// </summary>
        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public RepeatNotifySetting RepeatNotifySetting { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The synchronization source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Required for Update. Can be omitted for Create, in which case the backend generates it. The UUID is shared with NotifyStrategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
