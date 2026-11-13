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
        /// <para>Specifies whether the robot workspace is a large model workspace.</para>
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
        /// <item><description><para><b>appKey</b>: The appKey of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><b>maxEndSilence</b>: The duration of voice endpoint detection.</para>
        /// </description></item>
        /// <item><description><para><b>silenceTimeout</b>: The silence timeout in seconds. The timeout occurs after the user is silent for N seconds.</para>
        /// </description></item>
        /// <item><description><para><b>engine</b>: The service to call. Valid values: ali and xunfei.</para>
        /// </description></item>
        /// <item><description><para><b>nlsServiceType</b>: The type of the service to call. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Managed: The NLS service on the public cloud. </description></item>
        /// <item><description>Authorized: The authorized NLS service.</description></item>
        /// <item><description>Provided: The NLS service provided by the customer through AccessKey ID and AccessKey secret.</description></item>
        /// <item><description>Apes: The private cloud service.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: The configuration required when the caller is xunfei.</para>
        /// <remarks>
        /// <para>When engine is set to ali and nlsServiceType is set to Authorized, a custom service is used, and the service provider is ali. When engine is set to ali and nlsServiceType is set to Managed, the default service is used. When engine is set to xunfei and nlsServiceType is set to Authorized, the service provider is xunfei, and you must enter the xunfei configuration: {&quot;uuid&quot;:&quot;ed2xxxxxxxxx&quot;,&quot;globalMaxEndSilence&quot;:700,&quot;globalMaxEndSilenceEnable&quot;:true}.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>globalMaxEndSilence</b>: The silence detection duration in milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>globalMaxEndSilenceEnable</b>: The silence detection switch. Enabled by default.</para>
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
        /// <item><description>silenceConfig: The silence configuration.<list type="bullet">
        /// <item><description>silenceReplyTimeout: The silence reply timeout in milliseconds.</description></item>
        /// <item><description>silenceTimeoutMaxCount: The maximum number of silence timeout rounds before hanging up.</description></item>
        /// <item><description>silenceTimeoutMaxCountEnable: Specifies whether to hang up after silence timeouts.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>hangupConfig: The hang-up configuration.<list type="bullet">
        /// <item><description>aiHangupEnable: Specifies whether to enable AI hang-up. Valid values: true and false.</description></item>
        /// <item><description>delayHangup: The delayed hang-up time. Maximum value: 10.</description></item>
        /// <item><description>hangupMaxRounds: The maximum number of interaction rounds. Maximum value: 100.</description></item>
        /// <item><description>hangupMaxRoundsBroadcast: The broadcast script for hanging up.</description></item>
        /// <item><description>hangupMaxRoundsEnable: Specifies whether to enable the maximum interaction rounds check. Valid values: true and false.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>securityInterceptConfig: The security interception configuration.<list type="bullet">
        /// <item><description>broadcast: The interception broadcast script.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>specialInterceptConfig: The special case interception configuration.<list type="bullet">
        /// <item><description>specialInterceptEnable: Specifies whether to enable special case interception.</description></item>
        /// <item><description>specialIntercepts: The special cases.<list type="bullet">
        /// <item><description>voiceAssistant: Voice assistant.</description></item>
        /// <item><description>extensionNumberTransfer: Extension number transfer.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>transitionConfig: The backchannel model configuration.<list type="bullet">
        /// <item><description>transitionSwitch: Specifies whether to enable the backchannel model.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;silenceConfig&quot;:{&quot;silenceReplyTimeout&quot;:499,&quot;silenceTimeoutMaxCount&quot;:10,&quot;silenceTimeoutMaxCountEnable&quot;:true},&quot;hangupConfig&quot;:{&quot;aiHangupEnable&quot;:false,&quot;delayHangup&quot;:0,&quot;hangupMaxRounds&quot;:20,&quot;hangupMaxRoundsBroadcast&quot;:&quot;Thank you for taking my call. Have a great day. Goodbye!&quot;,&quot;hangupMaxRoundsEnable&quot;:false},&quot;securityInterceptConfig&quot;:{&quot;broadcast&quot;:&quot;I cannot answer this question. You can try asking other questions.&quot;},&quot;specialInterceptConfig&quot;:{&quot;specialInterceptEnable&quot;:false,&quot;specialIntercepts&quot;:[{&quot;code&quot;:&quot;voiceAssistant&quot;},{&quot;code&quot;:&quot;extensionNumberTransfer&quot;}]},&quot;transitionConfig&quot;:{&quot;transitionSwitch&quot;:false}}</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public string ChatConfig { get; set; }

        /// <summary>
        /// <para>The robot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-iFZfi7eq6e</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the emotion recognition configuration.</para>
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
        /// <para>E-commerce</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6320d3c-fa45-4011-b3b1-acdfabe3a8c6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The label definition.</para>
        /// <remarks>
        /// <para>Used in large model flow canvas scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;labels&quot;: [{
        ///         &quot;description&quot;: &quot;The customer\&quot;s final repayment intention after the conversation is completed&quot;,
        ///         &quot;name&quot;: &quot;Whether promised to repay&quot;,
        ///         &quot;valueList&quot;: &quot;[\&quot;Yes\&quot;,\&quot;No\&quot;]&quot;
        ///     }]
        /// }</para>
        /// </summary>
        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public string LabelConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the intelligent sentence segmentation configuration for small models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LongWaitEnable")]
        [Validation(Required=false)]
        public bool? LongWaitEnable { get; set; }

        /// <summary>
        /// <para>The backchannel configuration. Customization is not supported at the moment. You do not need to pass this parameter by default. <b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MiniPlaybackConfigListJsonString")]
        [Validation(Required=false)]
        public string MiniPlaybackConfigListJsonString { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the backchannel configuration for small models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MiniPlaybackEnable")]
        [Validation(Required=false)]
        public bool? MiniPlaybackEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful interruption configuration for small models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewBargeInEnable")]
        [Validation(Required=false)]
        public bool? NewBargeInEnable { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        /// <summary>
        /// <para>The NLU access method. This parameter is applicable only to large model scenarios.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Managed: Uses the Alibaba Cloud public account for access.</description></item>
        /// <item><description>Empty: For non-large model scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NluAccessType")]
        [Validation(Required=false)]
        public string NluAccessType { get; set; }

        /// <summary>
        /// <para>The NLU engine. This parameter is applicable only to large model scenarios.</para>
        /// <remarks>
        /// <para>After a scenario is created, the scenario mode cannot be modified.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prompts: The text input mode.</description></item>
        /// <item><description>SSE_FUNCTION: The Function Compute mode.</description></item>
        /// <item><description>Empty: For non-large model scenarios.</description></item>
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
        /// <para>Follow-up visit</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The script list for notification instances. <b>[Deprecated]</b></para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public List<string> ScriptContent { get; set; }

        /// <summary>
        /// <para>The script description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rework callback script</para>
        /// </summary>
        [NameInMap("ScriptDescription")]
        [Validation(Required=false)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c153d0d8-ba04-41c0-8632-453944c9dd0b</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The script name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Renewal reminder</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <para>The script voice list for notification instances. <b>[Deprecated]</b></para>
        /// </summary>
        [NameInMap("ScriptWaveform")]
        [Validation(Required=false)]
        public List<string> ScriptWaveform { get; set; }

        /// <summary>
        /// <para>The TTS configuration. Parameter definitions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>voice</b>: The speaker.</para>
        /// </description></item>
        /// <item><description><para><b>volume</b>: The volume. Valid values: 0 to 100. Default value: 50.</para>
        /// </description></item>
        /// <item><description><para><b>speechRate</b>: The speech rate. Valid values: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>pitchRate</b>: The pitch. Valid values: -500 to 500. Default value: 0.</para>
        /// </description></item>
        /// <item><description><para><b>openingPromptInterruptible</b>: The interruption configuration for the opening prompt.</para>
        /// </description></item>
        /// <item><description><para><b>closingStatementInterruptible</b>: The interruption configuration for the closing statement.</para>
        /// </description></item>
        /// <item><description><para><b>globalInterruptible</b>: The voice interruption configuration.</para>
        /// </description></item>
        /// <item><description><para><b>engine</b>: The service to call. Valid values: ali, volc, and xunfei. xunfei is not supported in large model scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>nlsServiceType</b>: The type of the service to call. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Managed: The NLS service on the public cloud. </description></item>
        /// <item><description>Authorized: The authorized NLS service.</description></item>
        /// <item><description>Provided: The NLS service provided by the customer through AccessKey ID and AccessKey secret.</description></item>
        /// <item><description>Apes: The private cloud service.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>engineXunfei</b>: The configuration when the service provider is xunfei.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <ol>
        /// <item><description>When engine is set to ali and nlsServiceType is set to Authorized, a custom service is used. 2. When the service provider is ali, engine is set to ali, and nlsServiceType is set to Managed, the default service is used. 3. When engine is set to xunfei (applicable to small model scenarios) and nlsServiceType is set to Authorized, the service provider is xunfei, and you must enter the engineXunfei configuration: {&quot;pitchRate&quot;:50,&quot;speechRate&quot;:50,&quot;voice&quot;:&quot;aisjiuxu&quot;,&quot;volume&quot;:50}. 4. When engine is set to volc and nlsServiceType is set to Authorized, the applicable service is doubao.</description></item>
        /// </ol>
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
