// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.MP3">https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.MP3</a></para>
        /// </summary>
        [NameInMap("DemoAudioMediaURL")]
        [Validation(Required=false)]
        public string DemoAudioMediaURL { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaozhuan</para>
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
