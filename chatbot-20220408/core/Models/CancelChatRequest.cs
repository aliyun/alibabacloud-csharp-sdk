// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CancelChatRequest : TeaModel {
        /// <summary>
        /// <para>The agent key. If unspecified, the default agent is used. You can obtain the key on the Business Management page of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The content of the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&lt;这个答案被打&gt;</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The ID that identifies a single chat turn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7105a351-b2e7-4c9e-8437-c43a043c0a4e</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The ID of the chatbot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The session ID is used to identify a visitor\&quot;s session and maintain context. For a new visitor, omit this parameter in the first call to the chat operation. The chatbot starts a session and returns the session ID in the response. For subsequent turns, you must pass the session ID to maintain context. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1187530338311ebade7cf3eaeb3668a</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The cancellation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Canceled</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
