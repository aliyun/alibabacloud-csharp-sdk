// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DebugDialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The next action returned by the dialogue engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Broadcast</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>Parameters for the returned action, as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>Indicates whether the Interactive Voice Response (IVR) playback can be interrupted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d74d6290-7cbe-4436-b5d7-014ebb0f4060</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The textual response from the dialogue engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d11be3-faad-4101-b4b0-59dbea28aaf0</para>
        /// </summary>
        [NameInMap("TextResponse")]
        [Validation(Required=false)]
        public string TextResponse { get; set; }

    }

}
