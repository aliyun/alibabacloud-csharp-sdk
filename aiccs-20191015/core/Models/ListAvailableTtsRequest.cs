// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListAvailableTtsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The personalized voice code. You can view the voice code on the <a href="https://aiccs.console.aliyun.com/engine/voiceprint">Personalized Voices</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V9A******</para>
        /// </summary>
        [NameInMap("TtsVoiceCode")]
        [Validation(Required=false)]
        public string TtsVoiceCode { get; set; }

        /// <summary>
        /// <para>The enumeration value of the TTS voice type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SYSTEM</c>: system voice.</description></item>
        /// <item><description><c>COSYCLONE</c>: cloned voice.</description></item>
        /// <item><description><c>BL-CUSTOM</c>: custom premium cloned voice.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("VoiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

    }

}
