// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCosyVoiceCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The media asset ID of the training audio material. Currently, only one audio material can be used for training.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public string Audios { get; set; }

        /// <summary>
        /// <para>The sample audio output address.  </para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, a sample audio file is generated at the specified OSS address after training succeeds.  <remarks>
        /// <para>Notice: The address must be a valid public OSS address under your account.</para>
        /// </remarks>
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
        /// <para>The voice cloning model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cosyvoice-v3-plus</b></description></item>
        /// <item><description><b>cosyvoice-v3-flash</b></description></item>
        /// <item><description><b>cosyvoice-v3.5-plus</b></description></item>
        /// <item><description><b>cosyvoice-v3.5-flash</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cosyvoice-v3-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The voice name. The name can be up to 32 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小专</para>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
