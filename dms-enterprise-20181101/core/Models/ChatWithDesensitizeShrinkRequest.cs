// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChatWithDesensitizeShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AudioJson")]
        [Validation(Required=false)]
        public string AudioJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserInfo</para>
        /// </summary>
        [NameInMap("DesensitizationRule")]
        [Validation(Required=false)]
        public string DesensitizationRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCodeInterpreter")]
        [Validation(Required=false)]
        public bool? EnableCodeInterpreter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSearch")]
        [Validation(Required=false)]
        public bool? EnableSearch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("MaxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;content&quot;: &quot;你好&quot;,
        ///         &quot;role&quot;: &quot;user&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public string MessagesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;text&quot;,&quot;audio&quot;]</para>
        /// </summary>
        [NameInMap("ModalitiesList")]
        [Validation(Required=false)]
        public string ModalitiesListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDesensitization")]
        [Validation(Required=false)]
        public bool? NeedDesensitization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("PresencePenalty")]
        [Validation(Required=false)]
        public string PresencePenalty { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResponseFormat")]
        [Validation(Required=false)]
        public string ResponseFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SearchOptions")]
        [Validation(Required=false)]
        public string SearchOptionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

        [NameInMap("Stop")]
        [Validation(Required=false)]
        public string StopShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public string Temperature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("ThinkingBudget")]
        [Validation(Required=false)]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TopLogprobs")]
        [Validation(Required=false)]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public string TopP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VlHighResolutionImages")]
        [Validation(Required=false)]
        public bool? VlHighResolutionImages { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("XDashScopeDataInspection")]
        [Validation(Required=false)]
        public string XDashScopeDataInspection { get; set; }

    }

}
