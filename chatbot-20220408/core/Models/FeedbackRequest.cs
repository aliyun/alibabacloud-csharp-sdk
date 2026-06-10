// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If this parameter is not set, the system uses the default business space. You can obtain the key from the business management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The feedback rating for the response. This parameter corresponds to <c>FeedbackType</c> in the session history API.</para>
        /// <para>Enumerated values: \&quot;good\&quot; (a positive rating) and \&quot;bad\&quot; (a negative rating).</para>
        /// 
        /// <b>Example:</b>
        /// <para>good</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>The detailed feedback content. You can provide this as a raw string or as a JSON string. If you use a JSON string, the \&quot;content\&quot; field corresponds to \&quot;FeedbackUserInfo\&quot; and the \&quot;feedbackLabels\&quot; field corresponds to \&quot;FeedbackLabels\&quot; in the session history.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;content&quot;: &quot;我觉得这个答案不对，需要依据事实回答。&quot;,
        ///     &quot;feedbackLabels&quot;: [
        ///         &quot;存在事实性错误&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// <para>The unique identifier of the chatbot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unique identifier of a single message within the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ca40988-4f99-47ad-ac96-9060d0f81db9</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The unique identifier for the session. The instant messaging (IM) system uses this ID to track the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c3cec23cc8940bc9db4a318c8f4f0aa</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
