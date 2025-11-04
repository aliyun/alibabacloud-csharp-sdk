// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SendAIAgentTextRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent instance.</para>
        /// <remarks>
        /// <para>InstanceId is a unique identifier that is returned when the AI agent is started. To start an AI agent, call <a href="https://help.aliyun.com/document_detail/2846201.html">StartAIAgentInstance </a> or <a href="https://help.aliyun.com/document_detail/2846209.html">GenerateAIAgentCall</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f27f9b9be28642a88e18****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The input to the LLM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
