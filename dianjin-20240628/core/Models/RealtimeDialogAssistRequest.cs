// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealtimeDialogAssistRequest : TeaModel {
        /// <summary>
        /// <para>Whether to analyze</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("analysis")]
        [Validation(Required=false)]
        public bool? Analysis { get; set; }

        /// <summary>
        /// <para>Business type. Currently, only dialogAssist is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dialogAssist</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Dialog list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationModel")]
        [Validation(Required=false)]
        public List<RealtimeDialogAssistRequestConversationModel> ConversationModel { get; set; }
        public class RealtimeDialogAssistRequestConversationModel : TeaModel {
            /// <summary>
            /// <para>Start time of this utterance, offset in milliseconds from the session start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>Start time of this utterance</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-12 09:00:00</para>
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>Specific content of the dialog</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你好</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Unique identity of the dialog role</para>
            /// 
            /// <b>Example:</b>
            /// <para>98457834685635</para>
            /// </summary>
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>Customer service ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1374683645635</para>
            /// </summary>
            [NameInMap("customerServiceId")]
            [Validation(Required=false)]
            public string CustomerServiceId { get; set; }

            /// <summary>
            /// <para>Agent type. 0: Robot, 1: Human.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("customerServiceType")]
            [Validation(Required=false)]
            public string CustomerServiceType { get; set; }

            /// <summary>
            /// <para>End time of this utterance, offset in milliseconds from the session start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <para>Role. 0 indicates customer, 1 indicates agent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            /// <summary>
            /// <para>Type of dialog content. Currently, only text is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Number of historical dialog turns included</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("dialogMemoryTurns")]
        [Validation(Required=false)]
        public int? DialogMemoryTurns { get; set; }

        /// <summary>
        /// <para>Hang up the session</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hangUpDialog")]
        [Validation(Required=false)]
        public bool? HangUpDialog { get; set; }

        /// <summary>
        /// <para>metaData</para>
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
        /// <para>Request ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Portion of the previous agent utterance already broadcast</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("scriptContentPlayed")]
        [Validation(Required=false)]
        public string ScriptContentPlayed { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1915593248420413441</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Whether the user interrupted</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("userVad")]
        [Validation(Required=false)]
        public bool? UserVad { get; set; }

    }

}
