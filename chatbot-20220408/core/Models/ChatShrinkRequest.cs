// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30002406051</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SandBox")]
        [Validation(Required=false)]
        public bool? SandBox { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custumer_123456</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9c6ebdc6e66f46ecadab3434314f6959</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;phone&quot;:123456789}</para>
        /// </summary>
        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

    }

}
