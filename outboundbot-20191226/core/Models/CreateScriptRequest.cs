// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateScriptRequest : TeaModel {
        /// <summary>
        /// <para>Robot workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1198938</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>Robot workspace access Key</para>
        /// 
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Is the robot workspace a Large Language Model (LLM) workspace?</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AgentLlm")]
        [Validation(Required=false)]
        public bool? AgentLlm { get; set; }

        /// <summary>
        /// <para>ASR configuration. Parameter definitions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appKey</b>: Alibaba Cloud account appKey.</para>
        /// </description></item>
        /// <item><description><para><b>maxEndSilence</b>: Voice endpoint detection duration.</para>
        /// </description></item>
        /// <item><description><para><b>silenceTimeout</b>: Silence timeout. Unit: seconds. The user times out after N seconds of silence.</para>
        /// </description></item>
        /// <item><description><para><b>engine</b>: Invoke service; [ali, xunfei]</para>
        /// </description></item>
        /// <item><description><para><b>nlsServiceType</b>: Invoke service type [Managed, Authorized]</para>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: If the caller is xunfei, enter the corresponding configuration.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you select ali as the engine and Authorized as the nlsServiceType, a custom service is used, and the service provider is ali. If you select ali as the engine and Managed as the nlsServiceType, the default service is used. If you select xunfei as the engine and Authorized as the nlsServiceType, xunfei is the service provider. You must enter the xunfei configuration: {&quot;uuid&quot;:&quot;ed2xxxxxxxxx&quot;,&quot;globalMaxEndSilence&quot;:700,&quot;globalMaxEndSilenceEnable&quot;:true}</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>globalMaxEndSilence</b>: Silence detection. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>globalMaxEndSilenceEnable</b>: Silence detection switch. Enabled by default.</para>
        /// </description></item>
        /// <item><description><para><b>speechNoiseThreshold</b>: Noise filtering threshold</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;appKey&quot;: &quot;oQDVNlE6fZ5mg46X&quot;,
        ///     &quot;engine&quot;: &quot;ali&quot;,
        ///     &quot;engineXunfei&quot;: &quot;&quot;,
        ///     &quot;globalMaxEndSilence&quot;: 700,
        ///     &quot;globalMaxEndSilenceEnable&quot;: true,
        ///     &quot;maxEndSilence&quot;: &quot;500&quot;,
        ///     &quot;nlsServiceType&quot;: &quot;Managed&quot;,
        ///     &quot;silenceTimeout&quot;: &quot;5000&quot;,
        ///     &quot;speechNoiseThreshold&quot;: &quot;0&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public string AsrConfig { get; set; }

        /// <summary>
        /// <para>If the NluServiceType of the instance is Authorized or Provided, specify the ID of the chatbot instance to which the script needs to be attached using this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-IfaUfqaUnb</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>Emotion detection configuration switch (applicable to small models)</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmotionEnable")]
        [Validation(Required=false)]
        public bool? EmotionEnable { get; set; }

        /// <summary>
        /// <para>Industry</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>教育</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c46001bc-3ead-4bfd-9a69-4b5b66a4a3f4</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Intelligent sentence segmentation configuration switch (applicable to small models)</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LongWaitEnable")]
        [Validation(Required=false)]
        public bool? LongWaitEnable { get; set; }

        /// <summary>
        /// <para>Connective phrase configuration switch (applicable to small models)</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MiniPlaybackEnable")]
        [Validation(Required=false)]
        public bool? MiniPlaybackEnable { get; set; }

        /// <summary>
        /// <para>Graceful interruption configuration switch (applicable to small models)</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewBargeInEnable")]
        [Validation(Required=false)]
        public bool? NewBargeInEnable { get; set; }

        /// <summary>
        /// <para>NLU access method (applicable only to Large Language Model (LLM) scenarios). Enumeration: Managed - Access using an Alibaba public account. This field is empty for non-LLM scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NluAccessType")]
        [Validation(Required=false)]
        public string NluAccessType { get; set; }

        /// <summary>
        /// <para>NLU engine (applicable only to Large Language Model (LLM) scenarios). This field is empty for non-LLM scenarios.</para>
        /// <list type="bullet">
        /// <item><description><para>Prompts - Large Language Model (LLM) scenario,</para>
        /// </description></item>
        /// <item><description><para>SSE_FUNCTION - Function Compute pattern.</para>
        /// </description></item>
        /// <item><description><para>BeeBot - Workflow pattern.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prompts</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

        /// <summary>
        /// <para>Scenario</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>回访</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>For notification instances, pass in the script list. Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public List<string> ScriptContent { get; set; }

        /// <summary>
        /// <para>Script description</para>
        /// 
        /// <b>Example:</b>
        /// <para>课程回复话术</para>
        /// </summary>
        [NameInMap("ScriptDescription")]
        [Validation(Required=false)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// <para>Script name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>课程满意度回访</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>If nluEngine is SSE_FUNCTION, you must pass in the corresponding configuration.</para>
        /// </remarks>
        /// <para>Function Compute service pattern configuration</para>
        /// <list type="bullet">
        /// <item><description><para>fcRegion: Function service region</para>
        /// </description></item>
        /// <item><description><para>fcFunction: Function service name</para>
        /// </description></item>
        /// <item><description><para>fcHttpTriggerUrl Function service trigger</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fcRegion&quot;:&quot;cn-shanghai&quot;,&quot;fcFunction&quot;:&quot;waihu_test&quot;,&quot;fcHttpTriggerUrl&quot;:&quot;<a href="https://waihu-test.xxxxxxxxxxx.cn-shanghai-vpc.fcapp.run%22%7D">https://waihu-test.xxxxxxxxxxx.cn-shanghai-vpc.fcapp.run&quot;}</a></para>
        /// </summary>
        [NameInMap("ScriptNluProfileJsonString")]
        [Validation(Required=false)]
        public string ScriptNluProfileJsonString { get; set; }

        /// <summary>
        /// <para>For notification instances, pass in the script voice list. Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ScriptWaveform")]
        [Validation(Required=false)]
        public List<string> ScriptWaveform { get; set; }

        /// <summary>
        /// <para>TTS configuration. Parameter definitions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>voice</b>: Speaker.</para>
        /// </description></item>
        /// <item><description><para><b>volume</b>: Volume. Value range: 0 to 100. Default value: 50.</para>
        /// </description></item>
        /// <item><description><para><b>speechRate</b>: Speech rate. Value range: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>pitchRate</b>: Pitch rate. Value range: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>globalInterruptible</b>: Voice interruption configuration.
        /// -<b>engine</b>: Invoke service; [ali, volc, xunfei]. Large Language Model (LLM) scenarios do not support xunfei.</para>
        /// </description></item>
        /// <item><description><para><b>nlsServiceType</b>: Service type. [Managed, Authorized]</para>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: Configuration when the service provider is xunfei.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>1\. If you select ali as the engine and Authorized as the nlsServiceType, a custom service is used. 2. If the service provider is ali, and you select ali as the engine and Managed as the nlsServiceType, the default service is used. 3. If you select xunfei as the engine (applicable to small model scenarios) and Authorized as the nlsServiceType, xunfei is the service provider. You must enter the engineXunfei configuration: {&quot;pitchRate&quot;:50,&quot;speechRate&quot;:50,&quot;voice&quot;:&quot;aisjiuxu&quot;,&quot;volume&quot;:50}. 4. If you select volc as the engine and Authorized as the nlsServiceType, it applies to doubao.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;appKey&quot;: &quot;oQDVNlE6fZ5mg46X&quot;,
        ///     &quot;engine&quot;: &quot;ali&quot;,
        ///     &quot;engineXunfei&quot;: &quot;&quot;,
        ///     &quot;globalInterruptible&quot;: true,
        ///     &quot;nlsServiceType&quot;: &quot;Managed&quot;,
        ///     &quot;pitchRate&quot;: &quot;0&quot;,
        ///     &quot;speechRate&quot;: &quot;0&quot;,
        ///     &quot;voice&quot;: &quot;zhiyuan&quot;,
        ///     &quot;volume&quot;: &quot;50&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public string TtsConfig { get; set; }

    }

}
