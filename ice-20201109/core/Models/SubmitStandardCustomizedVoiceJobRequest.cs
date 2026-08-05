// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitStandardCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The list of media asset IDs for training audio materials. Separate multiple media asset IDs with commas (,).</para>
        /// <remarks>
        /// <para>Notice: The total duration of all materials must be between 15 and 30 minutes, and the duration of each individual material must be greater than 1 minute.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public string Audios { get; set; }

        /// <summary>
        /// <para>The media asset ID of the authentication audio. Upload an audio clip to verify your identity. The task fails if the voiceprint does not match the training audio.</para>
        /// <remarks>
        /// <para>Notice: Read and record the following statement clearly: I confirm that I am initiating voice cloning customization. The training audio is provided by me. I commit to being responsible for the customized content and guarantee that no illegal or non-compliant content will be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Authentication")]
        [Validation(Required=false)]
        public string Authentication { get; set; }

        /// <summary>
        /// <para>The audio output address for the sample.  </para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, a sample audio file is generated at the specified OSS address after training succeeds.  </description></item>
        /// <item><description>If you do not specify this parameter, no sample audio is generated.<remarks>
        /// <para>Notice: The address must be a valid public OSS URL under your account.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.mp3">https://your-bucket.oss-cn-shanghai.aliyuncs.com/demo.mp3</a></para>
        /// </summary>
        [NameInMap("DemoAudioMediaURL")]
        [Validation(Required=false)]
        public string DemoAudioMediaURL { get; set; }

        /// <summary>
        /// <para>The gender. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>female</description></item>
        /// <item><description>male</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>female</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The voice name. The name can be up to 32 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
