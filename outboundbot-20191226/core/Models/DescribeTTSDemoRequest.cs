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
        /// <para>Enter the AK when the engine is xunfei.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5d0f37******<b><b>ef56db601</b></b></para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud custom voice ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>voice-e1be3a6</para>
        /// </summary>
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        /// <summary>
        /// <para>Speech service type</para>
        /// <list type="bullet">
        /// <item><description><para>When using <b>ali</b> as a custom service, enter the appKey of your Intelligent Speech Interaction project.</para>
        /// </description></item>
        /// <item><description><para>When using <b>xunfei</b> as a custom service, enter its appKey.</para>
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
        /// <para>Storage engine. Choose from ali, volc, or xunfei.</para>
        /// <list type="bullet">
        /// <item><description><para>Enter <b>ali</b> when using the default service or Alibaba Cloud as a custom service.</para>
        /// </description></item>
        /// <item><description><para>Enter <b>volc</b> when using the doubao service.</para>
        /// </description></item>
        /// <item><description><para>Enter <b>xunfei</b> when using iFLYTEK as a service provider. This option is only available for small-model scenarios.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8eccb3c-2b26-4b6d-a54f-696b953e33a6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Service type
        /// Managed: The default Intelligent Speech Interaction service for Intelligent Outbound Calling (public service).
        /// Authorized: An Intelligent Speech Interaction service you purchased on Alibaba Cloud public cloud (your private service). You can grant authorization by going to Scenario Management &gt; Edit &gt; Call Service &gt; Custom Service.</para>
        /// <remarks>
        /// <para>Set this parameter to Authorized when using Alibaba Cloud\&quot;s Intelligent Speech Interaction as your custom service provider.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>Pitch. An integer between -500 and 500. Default is 0.</para>
        /// <para>A value greater than 0 raises pitch.</para>
        /// <para>A value less than 0 lowers pitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>Scenario ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ab2d935-306c-478a-88bf-d08e4e25c1b7</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret (SK) for this namespace.</para>
        /// <remarks>
        /// <para>Enter the SK when the engine is xunfei.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OTdhNDE3Z****<b><b>zQ</b></b></para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>Speech rate. An integer between -500 and 500. Default is 0.</para>
        /// <para>A value greater than 0 increases speech speed.</para>
        /// <para>A value less than 0 decreases speech speed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <para>Text to convert to speech</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Voice ID. Examples include aixia, siyue, and xiaoyun. For the full list of available voices, see the voice list below.</para>
        /// <remarks>
        /// <para>Cloned voices use dynamic Voice IDs that are generated during voice cloning. Therefore, specific Voice IDs for cloned voices are not listed here. To get a cloned voice’s Voice ID, call ListVoiceClone from the voice cloning page.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>Volume. An integer between 0 and 100. Default is 50.</para>
        /// <para>A value greater than 50 increases volume.</para>
        /// <para>A value less than 50 decreases volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
