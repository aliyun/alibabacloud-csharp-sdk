// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the robot workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1198938</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>The access key for the robot workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Indicates whether the robot workspace is a Large Language Model (LLM) workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AgentLlm")]
        [Validation(Required=false)]
        public bool? AgentLlm { get; set; }

        /// <summary>
        /// <para>The ASR configuration. Parameter definitions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appKey</b>: The Alibaba Cloud account appKey.</para>
        /// </description></item>
        /// <item><description><para><b>maxEndSilence</b>: The duration for voice endpoint detection.</para>
        /// </description></item>
        /// <item><description><para><b>silenceTimeout</b>: The silence timeout. Unit: seconds. The system times out after the user is silent for N seconds.</para>
        /// </description></item>
        /// <item><description><para><b>engine</b>: The service to invoke. Valid values: ali, xunfei.</para>
        /// </description></item>
        /// <item><description><para><b>nlsServiceType</b>: The type of the invoked service.</para>
        /// <list type="bullet">
        /// <item><description><para>Managed: Public cloud NLS service.</para>
        /// </description></item>
        /// <item><description><para>Authorized: Authorized NLS service.</para>
        /// </description></item>
        /// <item><description><para>Provided: NLS service provided by the customer through AS/SK.</para>
        /// </description></item>
        /// <item><description><para>Apes: Private cloud service.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: If the caller is xunfei, fill in the corresponding configuration.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If engine is set to ali and nlsServiceType is set to Authorized, a custom service is used, and the service provider is ali. If engine is set to ali and nlsServiceType is set to Managed, the default service is used. If engine is set to xunfei and nlsServiceType is set to Authorized, the service provider is xunfei. You must fill in the xunfei configuration, such as {&quot;uuid&quot;:&quot;ed2xxxxxxxxx&quot;,&quot;globalMaxEndSilence&quot;:700,&quot;globalMaxEndSilenceEnable&quot;:true}.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>globalMaxEndSilence</b>: Silence detection. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>globalMaxEndSilenceEnable</b>: The switch for silence detection. Default value: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>speechNoiseThreshold</b>: The noise filtering threshold.</para>
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
        /// <para>The call configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>silenceConfig: Silence configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>silenceReplyTimeout: The timeout period for silence replies, in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>silenceTimeoutMaxCount: Hang up after several rounds of silence timeout.</para>
        /// </description></item>
        /// <item><description><para>silenceTimeoutMaxCountEnable: Indicates whether to hang up on silence.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>hangupConfig: Hang-up configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>aiHangupEnable: AI hang-up. Valid values: true, false.</para>
        /// </description></item>
        /// <item><description><para>delayHangup: Delayed hang-up. Maximum value: 10.</para>
        /// </description></item>
        /// <item><description><para>hangupMaxRounds: Interaction rounds. Maximum value: 100.</para>
        /// </description></item>
        /// <item><description><para>hangupMaxRoundsBroadcast: The script for hang-up broadcast.</para>
        /// </description></item>
        /// <item><description><para>hangupMaxRoundsEnable: Determine the maximum number of interaction rounds. Valid values: true, false.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>securityInterceptConfig: Security block configuration.</para>
        /// <list type="bullet">
        /// <item><description>broadcast: The script for block broadcast.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>specialInterceptConfig: Special case block.</para>
        /// <list type="bullet">
        /// <item><description><para>specialInterceptEnable: The switch for special case block.</para>
        /// </description></item>
        /// <item><description><para>specialIntercepts: Special cases.</para>
        /// <list type="bullet">
        /// <item><description><para>voiceAssistant: Voice assistant.</para>
        /// </description></item>
        /// <item><description><para>extensionNumberTransfer: Extension number transfer.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>transitionConfig: Transition phrase model configuration.</para>
        /// <list type="bullet">
        /// <item><description>transitionSwitch: The switch for the transition phrase model.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;silenceConfig&quot;:{&quot;silenceReplyTimeout&quot;:499,&quot;silenceTimeoutMaxCount&quot;:10,&quot;silenceTimeoutMaxCountEnable&quot;:true},&quot;hangupConfig&quot;:{&quot;aiHangupEnable&quot;:false,&quot;delayHangup&quot;:0,&quot;hangupMaxRounds&quot;:20,&quot;hangupMaxRoundsBroadcast&quot;:&quot;感谢您的接听，祝您生活愉快，再见!&quot;,&quot;hangupMaxRoundsEnable&quot;:false},&quot;securityInterceptConfig&quot;:{&quot;broadcast&quot;:&quot;您说的这个问题我不能回答您，您可以尝试询问其他问题。&quot;},&quot;specialInterceptConfig&quot;:{&quot;specialInterceptEnable&quot;:false,&quot;specialIntercepts&quot;:[{&quot;code&quot;:&quot;voiceAssistant&quot;},{&quot;code&quot;:&quot;extensionNumberTransfer&quot;}]},&quot;transitionConfig&quot;:{&quot;transitionSwitch&quot;:false}}</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public string ChatConfig { get; set; }

        /// <summary>
        /// <para>The ID of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-iFZfi7eq6e</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>The switch for emotion detection configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmotionEnable")]
        [Validation(Required=false)]
        public bool? EmotionEnable { get; set; }

        /// <summary>
        /// <para>The industry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>电商</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6320d3c-fa45-4011-b3b1-acdfabe3a8c6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public string LabelConfig { get; set; }

        /// <summary>
        /// <para>The switch for intelligent sentence segmentation configuration (small model).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LongWaitEnable")]
        [Validation(Required=false)]
        public bool? LongWaitEnable { get; set; }

        /// <summary>
        /// <para>The configuration for transition phrases. Customization is not supported temporarily. Do not pass this parameter by default. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("MiniPlaybackConfigListJsonString")]
        [Validation(Required=false)]
        public string MiniPlaybackConfigListJsonString { get; set; }

        /// <summary>
        /// <para>The switch for transition phrase configuration (small model).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MiniPlaybackEnable")]
        [Validation(Required=false)]
        public bool? MiniPlaybackEnable { get; set; }

        /// <summary>
        /// <para>The switch for graceful barge-in configuration (small model).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewBargeInEnable")]
        [Validation(Required=false)]
        public bool? NewBargeInEnable { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        /// <summary>
        /// <para>The NLU access method (applicable only to Large Language Model (LLM) scenarios).</para>
        /// <para>Enumeration:</para>
        /// <list type="bullet">
        /// <item><description><para>Managed: Access using an Alibaba Cloud public account.</para>
        /// </description></item>
        /// <item><description><para>This parameter is empty for non-LLM scenarios.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NluAccessType")]
        [Validation(Required=false)]
        public string NluAccessType { get; set; }

        /// <summary>
        /// <para>The NLU engine (applicable only to Large Language Model (LLM) scenarios).</para>
        /// <remarks>
        /// <para>After a scenario is created, you cannot modify the scenario mode.</para>
        /// </remarks>
        /// <para>Enumeration:</para>
        /// <list type="bullet">
        /// <item><description><para>Prompts: Text filling mode.</para>
        /// </description></item>
        /// <item><description><para>SSE_FUNCTION: Function Compute mode.</para>
        /// </description></item>
        /// <item><description><para>This parameter is empty for non-LLM scenarios.</para>
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
        /// <para>The scenario information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>回访</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>For notification instances, pass in the script list. This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public List<string> ScriptContent { get; set; }

        /// <summary>
        /// <para>The description of the script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>返工回访话术</para>
        /// </summary>
        [NameInMap("ScriptDescription")]
        [Validation(Required=false)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// <para>The ID of the script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c153d0d8-ba04-41c0-8632-453944c9dd0b</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The name of the script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>续费提醒</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <para>For notification instances, pass in the script voice list. This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("ScriptWaveform")]
        [Validation(Required=false)]
        public List<string> ScriptWaveform { get; set; }

        /// <summary>
        /// <para>The TTS configuration. Parameter definitions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>voice</b>: The voice actor.</para>
        /// </description></item>
        /// <item><description><para><b>volume</b>: The volume. Valid values: 0 to 100. Default value: 50.</para>
        /// </description></item>
        /// <item><description><para><b>speechRate</b>: The speech rate. Valid values: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>pitchRate</b>: The pitch rate. Valid values: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>globalInterruptible</b>: The voice interruption configuration.</para>
        /// </description></item>
        /// <item><description><para><b>engine</b></para>
        /// <para><b>nlsServiceType</b>: The type of the invoked service.</para>
        /// <list type="bullet">
        /// <item><description><para>Managed: Public cloud NLS service.</para>
        /// </description></item>
        /// <item><description><para>Authorized: Authorized NLS service.</para>
        /// </description></item>
        /// <item><description><para>Provided: NLS service provided by the customer through AS/SK.</para>
        /// </description></item>
        /// <item><description><para>Apes: Private cloud service.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: The configuration when the service provider is xunfei.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>1\. If engine is set to ali and nlsServiceType is set to Authorized, a custom service is used. 2. If the service provider is ali, and engine is set to ali and nlsServiceType is set to Managed, the default service is used. 3. If engine is set to xunfei (applicable to small model scenarios) and nlsServiceType is set to Authorized, the service provider is xunfei. You must fill in the engineXunfei configuration, such as {&quot;pitchRate&quot;:50,&quot;speechRate&quot;:50,&quot;voice&quot;:&quot;aisjiuxu&quot;,&quot;volume&quot;:50}. 4. If engine is set to volc and nlsServiceType is set to Authorized, it indicates that Doubao is applicable.</para>
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
