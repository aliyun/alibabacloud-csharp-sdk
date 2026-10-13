// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If this parameter is not specified, the default business space is accessed. You can obtain the key value on the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The feedback type, which corresponds to the FeedbackType field in the session history API.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>good: Like.</description></item>
        /// <item><description>bad: Dislike.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>good</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>The content of the like or dislike feedback. You can directly enter the feedback content or pass in a JSON string as shown in the example. The content field corresponds to FeedbackUserInfo in the session history, and feedbackLabels corresponds to FeedbackLabels in the session history.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;content&quot;: &quot;I think this answer is incorrect. It should be based on facts.&quot;,
        ///     &quot;feedbackLabels&quot;: [
        ///         &quot;Contains factual errors&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// <para>The unique identifier of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID that uniquely identifies a single message in a session window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ca40988-4f99-47ad-ac96-9060d0f81db9</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The session ID that uniquely identifies an IM session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c3cec23cc8940bc9db4a318c8f4f0aa</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
