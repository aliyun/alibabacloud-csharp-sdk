// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>good</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这个回答很棒</para>
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5ca40988-4f99-47ad-ac96-9060d0f81db9</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7c3cec23cc8940bc9db4a318c8f4f0aa</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
