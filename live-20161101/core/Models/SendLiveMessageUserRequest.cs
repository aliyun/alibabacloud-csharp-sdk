// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendLiveMessageUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application in which the message is sent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The message body. It can be up to 15 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello, user</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the message as a highly reliable message. A highly reliable message ensures that success is returned only after the receiver has received the message and responded. If the receiver does not respond within 3 seconds, failure is returned.</para>
        /// <list type="bullet">
        /// <item><description>true: sets the message as a highly reliable message.</description></item>
        /// <item><description>false (default): does not set the message as a highly reliable message.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only by the client SDK V1.5.1 and later. When you send a message to a client with an earlier SDK version, the message can be successfully sent without waiting for an acknowledgement (ACK) response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HighReliability")]
        [Validation(Required=false)]
        public bool? HighReliability { get; set; }

        /// <summary>
        /// <para>The ID of the message, which is a unique identifier that can be used to delete the message. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169830****</para>
        /// </summary>
        [NameInMap("MsgTid")]
        [Validation(Required=false)]
        public string MsgTid { get; set; }

        /// <summary>
        /// <para>The message type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public long? MsgType { get; set; }

        /// <summary>
        /// <para>The ID of the user who receives the message. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// <remarks>
        /// <para> Make sure that the user who receives the message is online. You can call the CheckLiveMessageUsersOnline operation to query whether the user is online.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid2</para>
        /// </summary>
        [NameInMap("ReceiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// <para>The ID of the user who sends the message. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <para>The additional information about the user who sends the message. It can be up to 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1meta1</para>
        /// </summary>
        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public string SenderInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to store the message.</para>
        /// <list type="bullet">
        /// <item><description>true: stores the message.</description></item>
        /// <item><description>false (default): does not store the message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public bool? Storage { get; set; }

    }

}
