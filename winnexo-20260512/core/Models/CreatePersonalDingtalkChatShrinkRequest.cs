// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalDingtalkChatShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The DingTalk group chat session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxxxxxx</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The group chat name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CustomerProjectGroup</para>
        /// </summary>
        [NameInMap("chatName")]
        [Validation(Required=false)]
        public string ChatName { get; set; }

        /// <summary>
        /// <para>The pipeline description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer group chat history</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The start time for collecting chat history.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01</para>
        /// </summary>
        [NameInMap("historyStartTime")]
        [Validation(Required=false)]
        public string HistoryStartTime { get; set; }

        /// <summary>
        /// <para>The meeting notes content (optional). The notes are used for auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Focus on identifying customer demands and to-do items</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The resource tags (optional, a JSON string list, such as [&quot;tagA&quot;,&quot;tagB&quot;]).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Customer&quot;,&quot;GroupChat&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The feature update frequency.</para>
        /// </summary>
        [NameInMap("updateFrequency")]
        [Validation(Required=false)]
        public string UpdateFrequencyShrink { get; set; }

    }

}
