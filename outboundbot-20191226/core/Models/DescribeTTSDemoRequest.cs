// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTTSDemoRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey (AK) of the namespace.</para>
        /// <remarks>
        /// <para>When the engine is xunfei, enter the AK here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5d0f37******<b><b>ef56db601</b></b></para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud custom voice, which is the voice invocation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>voice-e1be3a6</para>
        /// </summary>
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        /// <summary>
        /// <para>The speech service type.</para>
        /// <list type="bullet">
        /// <item><description><para>When you use <b>ali</b> as the custom service, this field stores the appKey of the interactive voice response product project.</para>
        /// </description></item>
        /// <item><description><para>When you use <b>xunfei</b> as the custom service provider, this field stores the corresponding appKey.</para>
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
        /// <para>The storage engine. Valid values: ali, volc, xunfei.</para>
        /// <list type="bullet">
        /// <item><description>When using traditional voices, CosyVoice, or selecting Alibaba Cloud as the custom service, set this to <b>ali</b>.</description></item>
        /// <item><description>When using the doubao service, set this to <b>volc</b>.</description></item>
        /// <item><description>When using xunfei as the service provider, set this to <b>xunfei</b> (can only be used in small model scenarios).</description></item>
        /// <item><description>When using your own service, set this to <b>dock</b>, and set NlsServiceType to Authorized.</description></item>
        /// <item><description>When using CV-v3-flash and Qwen voices, set this to <b>bailian</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The extended parameter. When Engine is set to <b>dock</b>, enter the configuration ID.</para>
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
        /// <para>The service type.
        /// Managed: the default service (public service) of the outbound robot product.
        /// Authorized: the interactive voice response service purchased by the public cloud customer (custom service), configured through system administration &gt; Third-party Voice Configuration.</para>
        /// <remarks>
        /// <para>When using Alibaba Cloud interactive voice response as the custom service provider, set this to Authorized.</para>
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
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ab2d935-306c-478a-88bf-d08e4e25c1b7</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The AccessKey Secret (SK) of the namespace.</para>
        /// <remarks>
        /// <para>When the engine is xunfei, enter the SK here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OTdhNDE3Z****<b><b>zQ</b></b></para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The speech rate. The value is an integer in the range of [-500, 500]. Default value: 0.</para>
        /// <para>A value greater than 0 increases the pitch.</para>
        /// <para>A value less than 0 decreases the pitch.</para>
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
        /// <para>The voice information, such as aixia, siyue, or xiaoyun. For the complete list of available voices, refer to the voice list below.</para>
        /// <remarks>
        /// <para>Because the Voice value for cloned voices is a non-fixed value generated during voice cloning, a specific Voice value cannot be provided at this stage. You can obtain the specific VoiceID from the voice cloning page by calling the ListVoiceClone operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>The volume. The value is an integer in the range of [0, 100]. Default value: 50.</para>
        /// <para>A value greater than 50 increases the volume.</para>
        /// <para>A value less than 50 decreases the volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
