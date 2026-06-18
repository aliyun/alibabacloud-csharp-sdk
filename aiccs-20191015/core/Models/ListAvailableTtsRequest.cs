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
        /// <para>The voice code for a custom voice. You can find it on the <a href="https://aiccs.console.aliyun.com/engine/voiceprint">Custom Voice</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V9A******</para>
        /// </summary>
        [NameInMap("TtsVoiceCode")]
        [Validation(Required=false)]
        public string TtsVoiceCode { get; set; }

        /// <summary>
        /// <para>The type of the TTS voice. Valid values:</para>
        /// <para><c>SYSTEM</c>: system voice.</para>
        /// <para><c>COSYCLONE</c>: cloned voice.</para>
        /// <para><c>BL-CUSTOM</c>: premium custom voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("VoiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

    }

}
