// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SendMessageChatTextRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The mode of message sending. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online</description></item>
        /// <item><description>offline</description></item>
        /// </list>
        /// <para>Default value: offline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Specifies whether to archive chat records. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedArchiving")]
        [Validation(Required=false)]
        public bool? NeedArchiving { get; set; }

        /// <summary>
        /// <para>The ID of the user who receives the message. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000042053</para>
        /// </summary>
        [NameInMap("ReceiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// <para>The ID of the session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f27f9b9be28642a88e18****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The content of the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>announcement: notification.</description></item>
        /// <item><description>custom: custom message.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>announcement</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
