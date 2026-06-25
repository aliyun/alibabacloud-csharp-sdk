// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTTSDemoRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey (AK) for this namespace.</para>
        /// <remarks>
        /// <para>When the engine is set to xunfei, you must enter the AK.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5d0f37******<b><b>ef56db601</b></b></para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud customized voice, which is the voice call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>voice-e1be3a6</para>
        /// </summary>
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        /// <summary>
        /// <para>Voice service type.</para>
        /// <list type="bullet">
        /// <item><description><para>When using <b>ali</b> as the custom service, this field stores the appKey of the Intelligent Speech Interaction product project.</para>
        /// </description></item>
        /// <item><description><para>When using <b>xunfei</b> as the custom service provider, this field stores the corresponding appKey.</para>
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
        /// <para>Storage engine. Valid values: ali, volc, and xunfei.</para>
        /// <list type="bullet">
        /// <item><description><para>When using the default service or selecting Alibaba Cloud as the custom service, set this parameter to <b>ali</b>.</para>
        /// </description></item>
        /// <item><description><para>When using the Doubao service, set this parameter to <b>volc</b>.</para>
        /// </description></item>
        /// <item><description><para>When using xunfei as the service provider, set this parameter to <b>xunfei</b>. This value can only be used in small model scenarios.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8eccb3c-2b26-4b6d-a54f-696b953e33a6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Service type.
        /// Managed: The default Intelligent Speech Interaction product service of the Outbound Bot product (public service).
        /// Authorized: The Intelligent Speech Interaction product service purchased by the public cloud customer (customer\&quot;s private service), authorized through Script Management &gt; Edit &gt; Call Service &gt; Custom Service.</para>
        /// <remarks>
        /// <para>When using Alibaba Cloud Intelligent Speech Interaction, that is, when using Alibaba Cloud as the custom service provider, set this parameter to Authorized.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>Pitch.
        /// An integer between [-500, 500]. Default value: 0.</para>
        /// <para>A value greater than 0 indicates a higher pitch.</para>
        /// <para>A value less than 0 indicates a lower pitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>Script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ab2d935-306c-478a-88bf-d08e4e25c1b7</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The AccessKey Secret (SK) for this namespace.</para>
        /// <remarks>
        /// <para>When the engine is set to xunfei, you must enter the SK.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OTdhNDE3Z****<b><b>zQ</b></b></para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>Speech rate.
        /// An integer between [-500, 500]. Default value: 0.</para>
        /// <para>A value greater than 0 indicates a faster speech rate.</para>
        /// <para>A value less than 0 indicates a slower speech rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <para>Text content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Voice information, such as aixia, siyue, or xiaoyun. For the complete list of available voices, refer to the voice list below.</para>
        /// <remarks>
        /// <para>Because the Voice value of a cloned voice is a unique, non-fixed value generated during voice cloning, the specific Voice value cannot be provided at this stage. You must obtain the specific VoiceID from the voice cloning page by calling the ListVoiceClone API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>Volume.
        /// An integer between [0, 100]. Default value: 50.</para>
        /// <para>A value greater than 50 indicates a higher volume.</para>
        /// <para>A value less than 50 indicates a lower volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
