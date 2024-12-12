// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAudioProduceJobRequest : TeaModel {
        /// <summary>
        /// <para>The job description.</para>
        /// <list type="bullet">
        /// <item><description>The job description can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>任务描述  长度不超过1024字节  UTF8编码</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The audio editing configurations.</para>
        /// <list type="bullet">
        /// <item><description>voice: the <a href="https://help.aliyun.com/document_detail/449563.html">voice type</a>.</description></item>
        /// <item><description>customizedVoice: the ID of the personalized human voice.</description></item>
        /// <item><description>format: the format of the output file. Valid values: PCM, WAV, and MP3.</description></item>
        /// <item><description>volume: the volume. Default value: 50. Valid values: 0 to 100.</description></item>
        /// <item><description>speech_rate: the speech tempo. Default value: 0. Value range: -500 to 500.</description></item>
        /// <item><description>pitch_rate: the intonation. Default value: 0. Value range: -500 to 500.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify both voice and customizedVoice, customizedVoice takes precedence over voice.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;voice&quot;:&quot;Siqi&quot;,&quot;format&quot;:&quot;MP3&quot;,&quot;volume&quot;:50}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The text content. A maximum of 2,000 characters are supported. The <a href="https://help.aliyun.com/document_detail/2672807.html">Speech Synthesis Markup Language (SSML)</a> is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文本</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output audio configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bucket&quot;:&quot;bucket&quot;,&quot;object&quot;:&quot;objeck&quot;}</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the existing Object Storage Service (OSS) object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The job title. If you do not specify this parameter, the system generates a title based on the current date.</para>
        /// <list type="bullet">
        /// <item><description>The job title can be up to 128 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>任务标题。若不提供，根据日期自动生成默认title  长度不超过128字节  UTF8编码</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
