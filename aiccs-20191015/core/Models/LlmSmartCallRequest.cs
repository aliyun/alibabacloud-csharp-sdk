// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallRequest : TeaModel {
        /// <summary>
        /// <para>LLM application code. View it in the <a href="https://aiccs.console.aliyun.com/engine/llmApp">Application Management</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32******</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>Business parameters. These parameters are passed to the customer model when invoking the customer model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz_params = {
        ///   &quot;user_prompt_params&quot;: &quot;{\&quot;city\&quot;:\&quot;北京\&quot;}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("BizParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizParam { get; set; }

        /// <summary>
        /// <para>Called number that receives the intelligent outbound call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>Caller number. This parameter is required and supports only numbers from the Chinese mainland. View available numbers in the Voice Service <a href="https://dyvmsnext.console.aliyun.com/number/list/normal">Number Management</a> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132****2054</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>Customer-provided ingest endpoint encoding.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use your own line, contact Alibaba Cloud support to enable this feature.</description></item>
        /// <item><description>The line encoding is provided by Alibaba Cloud support. Do not set this parameter if you do not have one.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_xxxxx_A_NET</para>
        /// </summary>
        [NameInMap("CustomerLineCode")]
        [Validation(Required=false)]
        public string CustomerLineCode { get; set; }

        /// <summary>
        /// <para>The extension number of the X number, up to 5 digits.</para>
        /// <remarks>
        /// <para>Notice: Fill this field only in AXN extension mode. If no extension number exists, do not fill it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>An ID reserved for the caller. This ID will be returned to the caller through a receipt message. Length: 1–15 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>Prompt variable. Go to the <a href="https://aiccs.console.aliyun.com/engine/llmApp">Application Management</a> interface and click Details to view the prompt variables you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;style&quot;: &quot;温柔&quot;
        /// }</para>
        /// </summary>
        [NameInMap("PromptParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptParam { get; set; }

        /// <summary>
        /// <para>Maximum call duration. The call is automatically disconnected after timeout. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Maximum value: 3600 s.</description></item>
        /// <item><description>Minimum value: 600 s.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>Start-word variables. Go to the <a href="https://aiccs.console.aliyun.com/engine/llmApp">LLM Application Management</a> interface and click Details to view the start-word variables of your created LLM application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;name&quot;: &quot;小明&quot;,
        ///   &quot;address&quot;: &quot;浙江省杭州市&quot;
        /// }</para>
        /// </summary>
        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> StartWordParam { get; set; }

        /// <summary>
        /// <para>Voice speed during TTS playback.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Value range: -200 to 200. Default value is 0.</description></item>
        /// <item><description>If this parameter is not set, the voice speed configured in the LLM application is used by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <para>The voice code used for TTS playback.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no value is set, the voice code configured in the LLM application is used by default.</description></item>
        /// <item><description>You can use the <a href="https://help.aliyun.com/document_detail/2926668.html">ListAvailableTts</a> API to view all available voice codes.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>V65******</para>
        /// </summary>
        [NameInMap("TtsVoiceCode")]
        [Validation(Required=false)]
        public string TtsVoiceCode { get; set; }

        /// <summary>
        /// <para>The volume for TTS playback.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Value range: 0–100. Default value is 0.</description></item>
        /// <item><description>If no value is set, the volume configured in the LLM application is used by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

    }

}
