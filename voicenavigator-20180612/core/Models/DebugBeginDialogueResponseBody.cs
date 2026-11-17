// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DebugBeginDialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The action instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Broadcast</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The parameters of the action instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;predictStopLongPauseConfig&quot;:&quot;{\&quot;NoSemantics\&quot;:1800, \&quot;PauseIntent\&quot;:2500, \&quot;IncompleteSemantics\&quot;:2000}&quot;,&quot;predictStopNluResponseMinTime&quot;:400,&quot;streamEnd&quot;:true,&quot;predictStopNluResponseMiddleWaitTime&quot;:5000,&quot;asrMaxEndSilence&quot;:600,&quot;predictStopAsrDelay&quot;:250,&quot;asrMaxBeginSilence&quot;:5000,&quot;predictStopVad&quot;:300,&quot;predictStopLongPause&quot;:1400,&quot;enableStreamChat&quot;:true}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>Indicates whether the IVR announcement can be interrupted.</para>
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
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The announcement content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, welcome to the intelligent assistant</para>
        /// </summary>
        [NameInMap("TextResponse")]
        [Validation(Required=false)]
        public string TextResponse { get; set; }

    }

}
