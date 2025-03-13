// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateTrainTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>13168123111</para>
        /// </summary>
        [NameInMap("aliyunMainId")]
        [Validation(Required=false)]
        public string AliyunMainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BASIC_MODEL</para>
        /// </summary>
        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CopyAnchorAndVoice</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>realTimeInteractivity</para>
        /// </summary>
        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M</para>
        /// </summary>
        [NameInMap("voiceGender")]
        [Validation(Required=false)]
        public string VoiceGender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("voiceLanguage")]
        [Validation(Required=false)]
        public string VoiceLanguage { get; set; }

        [NameInMap("voiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://yic-pre/video/test-0513.mp3">https://yic-pre/video/test-0513.mp3</a></para>
        /// </summary>
        [NameInMap("voicePath")]
        [Validation(Required=false)]
        public string VoicePath { get; set; }

    }

}
