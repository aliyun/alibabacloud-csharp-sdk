// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class EndToEndRealTimeDialogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the speech recognition model. The default value is nls-base. Supported models include paraformer-realtime-v2 and paraformer-realtime-8k-v2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nls-base</para>
        /// </summary>
        [NameInMap("asrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>The input audio format. Supported formats are pcm, wav, and mp3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcm</para>
        /// </summary>
        [NameInMap("inputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// <para>The output audio format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wav</para>
        /// </summary>
        [NameInMap("outputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>The pitch rate.
        /// ● If \<c>ttsModelId\\</c> is \<c>nls-base\\</c>:
        /// The value ranges from -500 to 500. The default is 0.
        /// ● If \<c>ttsModelId\\</c> is \<c>cosyvoice-v2\\</c>: Specifies the pitch of the synthesized audio. The value ranges from 0.5 to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>The sample rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAMPLE_RATE_16K</para>
        /// </summary>
        [NameInMap("sampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        /// <summary>
        /// <para>The speech rate.
        /// ● If \<c>ttsModelId\\</c> is \<c>nls-base\\</c>: The value ranges from -500 to 500. The default is 0.
        /// ● If \<c>ttsModelId\\</c> is \<c>cosyvoice-v2\\</c>:
        /// Specifies the speech rate of the synthesized audio. The value ranges from 0.5 to 2.
        /// ○ 0.5: Half the default speed.
        /// ○ 1: The default speed. The default speed is the model\&quot;s standard output speed and may vary slightly by speaker. It is about four characters per second.
        /// ○ 2: Twice the default speed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("speechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <para>The ID of the speech synthesis model. The default value is nls-base. The cosyvoice-v2 model is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nls-base</para>
        /// </summary>
        [NameInMap("ttsModelId")]
        [Validation(Required=false)]
        public string TtsModelId { get; set; }

        /// <summary>
        /// <para>The voice parameter. This is available only for models that support word-level or sentence-level timestamps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>longxiaochun_v2</para>
        /// </summary>
        [NameInMap("voiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <para>The volume. The value ranges from 0 to 100. This parameter is optional. The default value is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
