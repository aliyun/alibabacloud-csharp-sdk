// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class NotifyAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Create and query it in the console. Only a single ID is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aec****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Background audio.</para>
        /// </summary>
        [NameInMap("BackgroundMusic")]
        [Validation(Required=false)]
        public string BackgroundMusicShrink { get; set; }

        /// <summary>
        /// <para>The channel to join. Only a single ID is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>Custom parameters passed through to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;color&quot;:&quot;blue&quot;}</para>
        /// </summary>
        [NameInMap("CustomAttribute")]
        [Validation(Required=false)]
        public string CustomAttribute { get; set; }

        /// <summary>
        /// <para>Indicates whether the announcement can be interrupted. If false, the message cannot be interrupted by voice input, key presses, or other methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Interruptable")]
        [Validation(Required=false)]
        public bool? Interruptable { get; set; }

        /// <summary>
        /// <para>The text content to announce.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您好，现在是2025年4月16日，请问需要什么帮助</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The priority level for inserting the announcement:
        /// 1 — Interrupt the current interaction and announce immediately.
        /// 2 — Announce after the current interaction ends.
        /// 3 — Announce only if no interaction is active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
