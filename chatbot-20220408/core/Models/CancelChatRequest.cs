// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CancelChatRequest : TeaModel {
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
        /// <para>The answer content.</para>
        /// 
        /// <b>Example:</b>
        /// <This answer was inter>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The ID that identifies a single conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7105a351-b2e7-4c9e-8437-c43a043c0a4e</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The chatbot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The session ID, which is used to identify a visitor\&quot;s session and maintain context information. For a new visitor, you do not need to specify this parameter when calling the Chat operation for the first time. The chatbot starts a session and returns the SessionId in the response of the Chat operation. For subsequent conversation turns of the visitor, pass the SessionId of the current session when calling the Chat operation so that the chatbot can continue the conversation based on the SessionId. Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1187530338311ebade7cf3eaeb3668a</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The interruption type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Canceled</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
