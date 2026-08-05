// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveMessageUserMessageRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The data center, which must be the same as the data center specified in <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a>. Currently, Shanghai (cn-shanghai) and Singapore (ap-southeast-1) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The ID of the user who initiates the message deletion. The value consists of uppercase and lowercase letters and digits, and cannot exceed 64 bytes in length. This parameter is required in practice. If not specified, InputInvalid is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169830****</para>
        /// </summary>
        [NameInMap("DeleterId")]
        [Validation(Required=false)]
        public string DeleterId { get; set; }

        /// <summary>
        /// <para>The extended information of the user who initiates the message deletion. The value cannot exceed 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("DeleterInfo")]
        [Validation(Required=false)]
        public string DeleterInfo { get; set; }

        /// <summary>
        /// <para>The ID of the message to be deleted, which corresponds to the MsgTid in the send message operation. The value consists of uppercase and lowercase letters and digits, and cannot exceed 64 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The ID of the user who receives the delete message notification. The value consists of uppercase and lowercase letters and digits, and cannot exceed 64 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169830****</para>
        /// </summary>
        [NameInMap("ReceiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

    }

}
