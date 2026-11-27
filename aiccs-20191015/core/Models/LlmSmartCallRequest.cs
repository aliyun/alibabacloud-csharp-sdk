// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallRequest : TeaModel {
        /// <summary>
        /// <para>The code of the large language model application. You can view the code on the <a href="https://aiccs.console.aliyun.com/engine/llmApp">Large Language Model Application Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32******</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>The custom business parameters. When you call this API operation, you can pass custom parameters to the large language model gateway. When the large language model gateway requests the customer model, this parameter is passed to the customer model.</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://www.alibabacloud.com/help/en/model-studio/invoke-workflow-application/#6e644d5a7b3ia">Model Studio workflow application: Parameter passing</a>. Example: <c>biz_params = {&quot;city&quot;: &quot;Hangzhou&quot;}</c></para>
        /// </description></item>
        /// <item><description><para><a href="https://www.alibabacloud.com/help/en/model-studio/call-single-agent-application/#b774db7cdc0aa">Model Studio agent application: Pass custom parameters</a>. Example:
        /// <c>biz_params = { &quot;user_prompt_params&quot;: &quot;{\&quot;city\&quot;:\&quot;Beijing\&quot;}&quot; }</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>biz_params = {
        ///   &quot;user_prompt_params&quot;: &quot;{&quot;city&quot;:&quot;Beijing&quot;}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("BizParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizParam { get; set; }

        /// <summary>
        /// <para>The called number that receives the intelligent outbound call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The caller number. This parameter is required and supports only numbers in the Chinese mainland. Go to the <a href="https://dyvmsnext.console.aliyun.com/number/list/normal">Real Number Management</a> page of Voice Service to view the number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use a self-managed line, you must pass the number of the self-managed line.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>132****2054</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>The code of the self-managed line.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you need to use a self-managed line, contact operations to enable this feature. After the self-managed line is approved, the line code is returned. If no line code is returned, do not specify this parameter.</description></item>
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
        /// <para>The extension number of the X number. The extension number cannot exceed 5 digits.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required only in AXN extension number mode. If no extension number exists, do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in the receipt message. When the large language model gateway requests the customer model, this parameter is passed to the customer model. The length is 1 to 15 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The prompt variables. Go to the <a href="https://aiccs.console.aliyun.com/engine/llmApp">Large Language Model Application Management</a> page and click Details to view the prompt variables of the large language model application that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;style&quot;: &quot;gentle&quot;
        /// }</para>
        /// </summary>
        [NameInMap("PromptParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptParam { get; set; }

        /// <summary>
        /// <para>The maximum call duration. The call is automatically disconnected after the timeout period. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Maximum value: 3600.</description></item>
        /// <item><description>Minimum value: 600.</description></item>
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
        /// <para>The opening remark variables. Go to the <a href="https://aiccs.console.aliyun.com/engine/llmApp">Large Language Model Application Management</a> page and click Details to view the opening remark variables of the large language model application that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;name&quot;: &quot;Xiaoming&quot;,
        ///   &quot;address&quot;: &quot;Hangzhou, Zhejiang&quot;
        /// }</para>
        /// </summary>
        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> StartWordParam { get; set; }

        /// <summary>
        /// <para>The speech rate for TTS playback.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid values: -200 to 200. Default value: 0.</description></item>
        /// <item><description>If you do not specify this parameter, the speech rate configured for the large language model application is used by default.</description></item>
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
        /// <para>The voice code for text-to-speech (TTS) playback.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the voice code configured for the large language model application is used by default.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/2926668.html">ListAvailableTts</a> API operation to query all voice codes.</description></item>
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
        /// <item><description>Valid values: 0 to 100. Default value: 0.</description></item>
        /// <item><description>If you do not specify this parameter, the volume configured for the large language model application is used by default.</description></item>
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
