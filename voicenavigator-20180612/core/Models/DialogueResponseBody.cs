// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DialogueResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Broadcast</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;duration\&quot;:2420,\&quot;endTime\&quot;:1651717326805,\&quot;hangUpDirection\&quot;:\&quot;client\&quot;,\&quot;hasLastPlaybackCompleted\&quot;:true,\&quot;startTime\&quot;:1651717324385}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TextResponse")]
        [Validation(Required=false)]
        public string TextResponse { get; set; }

    }

}
