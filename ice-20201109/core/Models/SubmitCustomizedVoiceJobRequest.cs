// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the sample audio file.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is specified, a sample audio file is generated at the specified Object Storage Service (OSS) URL after the training is complete.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, no sample audio file is generated.</para>
        /// <para>**</para>
        /// <para><b>Note</b>: The URL must be a valid public OSS URL within your Alibaba Cloud account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.MP3">https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.MP3</a></para>
        /// </summary>
        [NameInMap("DemoAudioMediaURL")]
        [Validation(Required=false)]
        public string DemoAudioMediaURL { get; set; }

        /// <summary>
        /// <para>The voice ID.</para>
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
