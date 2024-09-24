// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitStandardCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public string Audios { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Authentication")]
        [Validation(Required=false)]
        public string Authentication { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.mp3">https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.mp3</a></para>
        /// </summary>
        [NameInMap("DemoAudioMediaURL")]
        [Validation(Required=false)]
        public string DemoAudioMediaURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>female</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
