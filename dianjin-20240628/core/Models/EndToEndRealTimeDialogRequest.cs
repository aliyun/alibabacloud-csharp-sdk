// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class EndToEndRealTimeDialogRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>nls-base</para>
        /// </summary>
        [NameInMap("asrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pcm</para>
        /// </summary>
        [NameInMap("inputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wav</para>
        /// </summary>
        [NameInMap("outputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAMPLE_RATE_16K</para>
        /// </summary>
        [NameInMap("sampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("speechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nls-base</para>
        /// </summary>
        [NameInMap("ttsModelId")]
        [Validation(Required=false)]
        public string TtsModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>longxiaochun_v2</para>
        /// </summary>
        [NameInMap("voiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
