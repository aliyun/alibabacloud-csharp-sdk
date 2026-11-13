// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTTSDemoRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the namespace.</para>
        /// <remarks>
        /// <para>When the engine is xunfei, you must enter the AccessKey ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5d0f37******<b><b>ef56db601</b></b></para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud custom voice, which is the voice call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>voice-e1be3a6</para>
        /// </summary>
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        /// <summary>
        /// <para>The speech service type. </para>
        /// <list type="bullet">
        /// <item><description><para>When <b>ali</b> is used as the custom service, this field stores the AppKey of the interactive voice response project.</para>
        /// </description></item>
        /// <item><description><para>When <b>xunfei</b> is used as the custom service provider, this field stores the corresponding AppKey.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xusi*******RnP7</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The storage engine. Valid values: <b>ali</b>, <b>volc</b>, and <b>xunfei</b>.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>ali</b> when you use traditional voices, CosyVoice, or Alibaba Cloud as the custom service.</description></item>
        /// <item><description>Set the value to <b>volc</b> when you use the Doubao service.</description></item>
        /// <item><description>Set the value to <b>xunfei</b> when you use iFLYTEK as the service provider. This value can only be used in small model scenarios.</description></item>
        /// <item><description>Set the value to <b>dock</b> and set NlsServiceType to Authorized when you use a self-managed service.</description></item>
        /// <item><description>Set the value to <b>bailian</b> when you use CV-v3-flash and Qwen voices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The extended parameters. When Engine is set to <b>dock</b>, you must specify the configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;thirdVoiceConfigUuid&quot;:&quot;3cd82813ece049c4aff3ea3d***********&quot;}</para>
        /// </summary>
        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8eccb3c-2b26-4b6d-a54f-696b953e33a6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Managed: the default service for the outbound robot product, which is a public service.</description></item>
        /// <item><description>Authorized: the interactive voice response service purchased by public cloud customers, which is a custom service. You can configure it by choosing system administration &gt; third-party speech configuration.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you need to use Alibaba Cloud interactive voice response, which means using Alibaba Cloud as the custom service provider, set the value to Authorized.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>The pitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>The sample rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ab2d935-306c-478a-88bf-d08e4e25c1b7</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret of the namespace.</para>
        /// <remarks>
        /// <para>When the engine is xunfei, you must enter the AccessKey secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OTdhNDE3Z****<b><b>zQ</b></b></para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The speech rate. Valid values: an integer from -500 to 500. Default value: 0. A value greater than 0 increases the pitch. A value less than 0 decreases the pitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <para>The text content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The voice information, such as aixia, siyue, or xiaoyun. For the complete list of voices, refer to the voice list below.</para>
        /// <remarks>
        /// <para>Because the voice ID for a cloned voice is a dynamic value generated during voice cloning, a specific voice ID cannot be provided at this stage. To obtain the specific voice ID, you must call the ListVoiceClone operation on the cloned voice page.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>The volume. Valid values: an integer from 0 to 100. Default value: 50. A value greater than 50 increases the volume. A value less than 50 decreases the volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
