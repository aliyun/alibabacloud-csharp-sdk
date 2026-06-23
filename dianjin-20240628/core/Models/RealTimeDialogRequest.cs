// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealTimeDialogRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("analysis")]
        [Validation(Required=false)]
        public bool? Analysis { get; set; }

        /// <summary>
        /// <para>The business type. The default value is mixIntentChat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mixIntentChat</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The list of conversations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationModel")]
        [Validation(Required=false)]
        public List<RealTimeDialogRequestConversationModel> ConversationModel { get; set; }
        public class RealTimeDialogRequestConversationModel : TeaModel {
            /// <summary>
            /// <para>The start time of the sentence, in milliseconds, relative to the start of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>The start time of this sentence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-08 09:51:16</para>
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The specific content of the conversation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>人工客服</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The unique ID of the conversation role. This parameter is <b>required</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98457834685635</para>
            /// </summary>
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>The ID of the customer service representative. This parameter is <b>required</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1374683645635</para>
            /// </summary>
            [NameInMap("customerServiceId")]
            [Validation(Required=false)]
            public string CustomerServiceId { get; set; }

            /// <summary>
            /// <para>The type of the customer service representative. 0: bot, 1: human.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("customerServiceType")]
            [Validation(Required=false)]
            public string CustomerServiceType { get; set; }

            /// <summary>
            /// <para>The end time of the sentence, in milliseconds, relative to the start of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <para>The intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198379874354</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            /// <summary>
            /// <para>The role. 0 indicates the customer, and 1 indicates the customer service representative.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            /// <summary>
            /// <para>The type of the conversation content. Valid values: text, audio, and image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of historical conversation turns to include.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("dialogMemoryTurns")]
        [Validation(Required=false)]
        public int? DialogMemoryTurns { get; set; }

        /// <summary>
        /// <para>The metadata used to encapsulate prompts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;phoneTailNumber&quot;: &quot;机主尾号：98X1&quot;,
        ///       &quot;preScreeningQuota&quot;: &quot;预审额度：3万&quot;,
        ///       &quot;generalInterest&quot;: &quot;平台一般利息：20.4%&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("metaData")]
        [Validation(Required=false)]
        public Dictionary<string, object> MetaData { get; set; }

        /// <summary>
        /// <para>The operation type. Only common and hierarchical are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("opType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// <para>The recommended intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recommend")]
        [Validation(Required=false)]
        public bool? Recommend { get; set; }

        /// <summary>
        /// <para>The part of the previous script from the customer service representative that has been played.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好，我是</para>
        /// </summary>
        [NameInMap("scriptContentPlayed")]
        [Validation(Required=false)]
        public string ScriptContentPlayed { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237645726354</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the response in a stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>Specifies whether the user interrupted the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("userVad")]
        [Validation(Required=false)]
        public bool? UserVad { get; set; }

    }

}
