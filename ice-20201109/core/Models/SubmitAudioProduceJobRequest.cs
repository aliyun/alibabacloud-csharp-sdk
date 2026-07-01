// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAudioProduceJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the job.</para>
        /// <list type="bullet">
        /// <item><description><para>Cannot exceed 1,024 bytes.</para>
        /// </description></item>
        /// <item><description><para>Must be UTF-8 encoded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Task description, max 1024 bytes, UTF-8 encoded</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The audio production configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><c>voice</c>: The <a href="https://help.aliyun.com/document_detail/449563.html">voice type</a>.</para>
        /// </description></item>
        /// <item><description><para><c>customizedVoice</c>: The ID of the custom voice for voice cloning.</para>
        /// </description></item>
        /// <item><description><para><c>format</c>: The output file format. Supported formats: <c>PCM</c>, <c>WAV</c>, and <c>MP3</c>.</para>
        /// </description></item>
        /// <item><description><para><c>volume</c>: The volume. The value ranges from 0 to 100. Default: 50.</para>
        /// </description></item>
        /// <item><description><para><c>speech_rate</c>: The speech rate. The value ranges from -500 to 500. Default: 0.</para>
        /// <list type="bullet">
        /// <item><description><para>Values of -500, 0, and 500 correspond to 0.5x, 1.0x, and 2.0x speed, respectively.</para>
        /// </description></item>
        /// <item><description><para>Calculation method:</para>
        /// <list type="bullet">
        /// <item><description><para>For a 0.8x speed multiplier: (1 - 1/0.8) / 0.002 = -125.</para>
        /// </description></item>
        /// <item><description><para>For a 1.2x speed multiplier: (1 - 1/1.2) / 0.001 = 166.</para>
        /// </description></item>
        /// <item><description><para>For speed multipliers less than 1, use a factor of 0.002.</para>
        /// </description></item>
        /// <item><description><para>For speed multipliers greater than 1, use a factor of 0.001.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>pitch_rate</c>: The pitch rate. The value ranges from -500 to 500. Default: 0.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you provide both <c>voice</c> and <c>customizedVoice</c>, <c>customizedVoice</c> takes precedence.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;voice&quot;:&quot;Siqi&quot;,&quot;format&quot;:&quot;MP3&quot;,&quot;volume&quot;:50}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The text to synthesize. The maximum length is 10,000 characters. Supports <a href="https://help.aliyun.com/document_detail/2672807.html">SSML</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Audio production task</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The audio output configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For example, to store the output audio at <a href="http://my_bucket.oss-cn-shanghai.aliyuncs.com/target_audio.mp3">http://my_bucket.oss-cn-shanghai.aliyuncs.com/target_audio.mp3</a>, configure this parameter as:
        /// {
        ///       &quot;bucket&quot;: &quot;my_bucket&quot;,
        ///       &quot;object&quot;: &quot;target_audio&quot;
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite an existing OSS file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The title of the job. If you do not provide a title, the system automatically generates one based on the current date.</para>
        /// <list type="bullet">
        /// <item><description><para>Cannot exceed 128 bytes.</para>
        /// </description></item>
        /// <item><description><para>Must be UTF-8 encoded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>China Regional Daily News</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Custom settings in JSON format. The maximum length is 512 bytes. This parameter supports <a href="https://help.aliyun.com/document_detail/451631.html">custom callback address configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
