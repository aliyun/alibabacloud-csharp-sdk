// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SendAIAgentSpeechRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the broadcast can interrupt the ongoing speech. Default value: true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInterrupt")]
        [Validation(Required=false)]
        public bool? EnableInterrupt { get; set; }

        /// <summary>
        /// <para>Agent instance ID.</para>
        /// <remarks>
        /// <para>The InstanceId is the unique ID returned after successfully starting an agent instance. For details about starting an agent instance, see <a href="https://help.aliyun.com/document_detail/2846201.html">StartAIAgentInstance</a> and <a href="https://help.aliyun.com/document_detail/2846209.html">GenerateAIAgentCall</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The text content to be played back. The supported input format varies based on the Type parameter. The length cannot exceed 1024 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, welcome to our service.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Input type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Text: Input is plain text.</para>
        /// </description></item>
        /// <item><description><para>AudioUrl: Input is an audio URL.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
