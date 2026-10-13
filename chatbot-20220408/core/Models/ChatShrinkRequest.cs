// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If this parameter is not specified, the default business space is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique chatbot identifier (chatbot ID). Log on to the Chatbot console and navigate to Chatbot Details &gt; Session Interface to view the chatbot instance information and obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The intent name in the dialog flow. If this name is specified, the chatbot directly enters this intent for Q&amp;A.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckWeatherIntent</para>
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <para>The ID of a knowledge title in the knowledge base. If this ID is specified, the chatbot directly returns the answer for the specified knowledge title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30002406051</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// <para>The array of perspective codes, which is used to call answers from different perspectives under the same knowledge title. Example: Perspective=[&quot;FZJBY3raWr&quot;]. When using the SDK, use the parameters defined in the SDK.</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the test or production environment. Default value: false (production environment). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Test environment. This is for testing only. Using it in production may cause instability and QPS throttling.</description></item>
        /// <item><description>false: Production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SandBox")]
        [Validation(Required=false)]
        public bool? SandBox { get; set; }

        /// <summary>
        /// <para>The visitor ID, which identifies the user in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custumer_123456</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <para>The nickname of the visitor in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User123456</para>
        /// </summary>
        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// <para>The session ID, which identifies a visitor\&quot;s session and maintains context information. For a new visitor, you do not need to pass this field when calling the Chat operation for the first time. The chatbot starts a session and returns the SessionId in the response of the Chat operation. For subsequent conversation turns of the visitor, pass the SessionId of the current session when calling the Chat operation so that the chatbot can continue the conversation based on the SessionId. Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c6ebdc6e66f46ecadab3434314f6959</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The input from the chatbot visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How is the weather today?</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        /// <summary>
        /// <para>A JSON-formatted set of user-defined parameters that can be passed to various dialog engines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;phone&quot;:123456789}</para>
        /// </summary>
        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

    }

}
