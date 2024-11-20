// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitStandardCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The material assets IDs of the materials for training.</description></item>
        /// <item><description>Separate multiple media IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>: The total duration of all materials must be within 15 to 30 minutes. The duration of each material must be greater than 1 minute.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b>,<b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public string Audios { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The media asset ID of the authentication audio.</para>
        /// </description></item>
        /// <item><description><para>Upload an audio file for identity authentication. If the voiceprint extracted from the uploaded file differs from that of the training file, the job fails.</para>
        /// <para>**</para>
        /// <para><b>Note</b>: Clearly read and record the following text: I confirm to customize human voice cloning and provide audio files that contain my voice for training. I promise that I am responsible for the customized content and that the content complies with laws and regulations.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Authentication")]
        [Validation(Required=false)]
        public string Authentication { get; set; }

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
        /// <para>The voice name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 32 characters in length.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
