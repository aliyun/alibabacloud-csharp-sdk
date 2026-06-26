// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeTTSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom voice ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc458bba-5a25-4cbc-b5c2</para>
        /// </summary>
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        /// <summary>
        /// <para>The AppKey of the third-party voice configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b358afc</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The TTS engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The iFLYTEK engine parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Voice\&quot;:\&quot;aisjinger\&quot;}</para>
        /// </summary>
        [NameInMap("EngineXunfei")]
        [Validation(Required=false)]
        public string EngineXunfei { get; set; }

        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <para>The TTS service invoke type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>The pitch rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F132DDBA-66C4-5BD3-BF7E-9642FE877158</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The speech rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-150</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <para>The TTS error correction dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;pronunciation\&quot;:\&quot;环钱\&quot;,\&quot;word\&quot;:\&quot;还钱\&quot;}]</para>
        /// </summary>
        [NameInMap("TtsOverrides")]
        [Validation(Required=false)]
        public string TtsOverrides { get; set; }

        /// <summary>
        /// <para>The voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>The volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
