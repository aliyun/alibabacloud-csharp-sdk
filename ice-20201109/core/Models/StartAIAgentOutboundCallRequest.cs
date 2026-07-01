// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartAIAgentOutboundCallRequest : TeaModel {
        /// <summary>
        /// <para>The AI agent ID configured in the <a href="https://ims.console.aliyun.com/ai/robot/list">IMS console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*******<b><b>e4f309379701645f4</b></b></para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173*****533</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The caller number. Only numbers from mainland China are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183*****333</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>The AI agent outbound call configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfig Config { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ImsAIAgentFreeObCall")]
        [Validation(Required=false)]
        public string ImsAIAgentFreeObCall { get; set; }

        /// <summary>
        /// <para>A unique identifier for the session. You can use this ID to store, query, and synchronize chat history across multiple calls. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f213fbc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;city&quot;:&quot;Hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
