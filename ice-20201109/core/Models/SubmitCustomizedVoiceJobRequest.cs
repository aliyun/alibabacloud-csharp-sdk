// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The OSS URL where the demo audio will be saved.</para>
        /// <list type="bullet">
        /// <item><description><para>If specified, the service generates a demo audio file at the provided OSS URL after training completes.</para>
        /// </description></item>
        /// <item><description><remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The URL must be a valid public address for an OSS object in your account.</para>
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
        /// <para>The unique identifier for the voice.</para>
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
