// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If omitted, the request is routed to the default business space. You can get this key from the <b>Business Management</b> page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique ID of the chatbot instance. To get this ID, log in to the Alibaba Cloud Chatbot console and go to <b>Chatbot Details</b> &gt; <b>Session API</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of an intent within a dialog flow. If specified, the chatbot directly activates this intent to process the user\&quot;s request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查天气意图</para>
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <para>The ID of an entry in the knowledge base. If you specify this ID, the chatbot directly returns the corresponding answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30002406051</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// <para>An array of perspective codes. Use these codes to retrieve answers from different perspectives for the same knowledge entry. Example: <c>Perspective=[&quot;FZJBY3raWr&quot;]</c>. When using an SDK, refer to its parameter definitions.</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// <para>Specifies the environment to use. The default value is <c>false</c>, which indicates the production environment.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The test environment. This environment is for testing only. Do not use it in production due to potential instability and QPS limitations.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SandBox")]
        [Validation(Required=false)]
        public bool? SandBox { get; set; }

        /// <summary>
        /// <para>The unique ID of the user in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custumer_123456</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <para>The nickname of the user in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户123456</para>
        /// </summary>
        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// <para>The session ID, used to identify a user session and maintain context. For a new user, omit this parameter in the first call to the <c>Chat</c> API. The chatbot automatically starts a session and returns the <c>SessionId</c> in the response. To continue the conversation, include this <c>SessionId</c> in all subsequent requests. The maximum length is 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c6ebdc6e66f46ecadab3434314f6959</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user\&quot;s input text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>今天天气怎么样？</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string containing custom parameters to pass to various dialog engines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;phone&quot;:123456789}</para>
        /// </summary>
        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

    }

}
