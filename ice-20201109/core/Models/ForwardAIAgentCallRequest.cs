// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ForwardAIAgentCallRequest : TeaModel {
        /// <summary>
        /// <para>The target phone number for call transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13**********</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The caller phone number for the transferred call. Optional.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>By default, the CallerNumber is the agent\&quot;s phone number after the call starts:
        /// 1\. For inbound lines, the agent number is the agent’s seat number.
        /// 2\. For outbound lines, the agent number is the original caller number.</para>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Alibaba Cloud lines do not support this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13**********</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>Abnormal prompt text played when the transfer fails. Default is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>We’re sorry, we’re unable to transfer your call at the moment. Please try again later.</para>
        /// </summary>
        [NameInMap("ErrorPrompt")]
        [Validation(Required=false)]
        public string ErrorPrompt { get; set; }

        /// <summary>
        /// <para>Current call instance ID, used only in inbound call transfer scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call_instance_202******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Prompt message played before initiating the transfer. If empty, the system skips the prompt and plays the ringing tone directly. Default is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please hold while I transfer your call.</para>
        /// </summary>
        [NameInMap("TransferPrompt")]
        [Validation(Required=false)]
        public string TransferPrompt { get; set; }

    }

}
