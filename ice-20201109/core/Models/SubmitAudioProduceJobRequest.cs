// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAudioProduceJobRequest : TeaModel {
        /// <summary>
        /// <para>The task description:</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 1024 bytes.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
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
        /// <item><description>voice: the <a href="https://help.aliyun.com/document_detail/449563.html">voice type</a>.</description></item>
        /// <item><description>customizedVoice: the VoiceId for voice cloning.</description></item>
        /// <item><description>format: the output file format. Valid values: PCM, WAV, and MP3.</description></item>
        /// <item><description>volume: the volume. Valid values: 0 to 100. Default value: 50.</description></item>
        /// <item><description>speech_rate: the speech rate. Valid values: -500 to 500. Default value: 0.<list type="bullet">
        /// <item><description>[-500, 0, 500] corresponds to the speed multiplier range of [0.5, 1.0, 2.0].</description></item>
        /// <item><description>The calculation method is as follows:<list type="bullet">
        /// <item><description>0.8x speed: (1-1/0.8)/0.002 = -125</description></item>
        /// <item><description>1.2x speed: (1-1/1.2)/0.001 = 166</description></item>
        /// <item><description>For speeds less than 1x, use the 0.002 coefficient.</description></item>
        /// <item><description>For speeds greater than 1x, use the 0.001 coefficient.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>pitch_rate: the pitch. Valid values: -500 to 500. Default value: 0.
        /// <notice>If both voice and customizedVoice are specified, customizedVoice takes precedence.</description></item>
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
        /// <para>The text content. A maximum of 10,000 Chinese characters is supported. <a href="https://help.aliyun.com/document_detail/2672807.html">SSML markup language</a> is supported.</para>
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
        /// <para>Specifies whether to overwrite existing OSS files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The task title. If not provided, a default title is automatically generated based on the date.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 128 bytes.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>China Regional Daily News</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. Maximum length: 512 bytes. <a href="https://help.aliyun.com/document_detail/451631.html">Custom callback URL configuration</a> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
