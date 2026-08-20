// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalFeishuChatRequest : TeaModel {
        /// <summary>
        /// <para>The group chat session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oc_abc123</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The description of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product R&amp;D group chat records</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir_personal_1</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The start time for historical messages. Supports YYYY-MM-DD or YYYY-MM-DD HH:MM:SS. If not specified, all visible history is pulled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01 00:00:00</para>
        /// </summary>
        [NameInMap("historyStartTime")]
        [Validation(Required=false)]
        public string HistoryStartTime { get; set; }

        /// <summary>
        /// <para>The meeting notes content (optional). Used for auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Focus on extracting decisions and action items</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The source tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;R&amp;D&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The tenant ID to take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The update frequency.</para>
        /// </summary>
        [NameInMap("updateFrequency")]
        [Validation(Required=false)]
        public CreatePersonalFeishuChatRequestUpdateFrequency UpdateFrequency { get; set; }
        public class CreatePersonalFeishuChatRequestUpdateFrequency : TeaModel {
            /// <summary>
            /// <para>The cron expression for the timed scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 * * * *</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the scheduled synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The synchronization preset: hourly or daily_2am.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hourly</para>
            /// </summary>
            [NameInMap("preset")]
            [Validation(Required=false)]
            public string Preset { get; set; }

        }

    }

}
