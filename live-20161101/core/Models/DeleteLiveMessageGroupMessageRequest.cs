// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveMessageGroupMessageRequest : TeaModel {
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
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The ID of the user who deletes the message. The ID must be up to 64 bytes in length and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169830****</para>
        /// </summary>
        [NameInMap("DeleterId")]
        [Validation(Required=false)]
        public string DeleterId { get; set; }

        /// <summary>
        /// <para>The additional information about the user who performs the deletion operation. The value can be up to 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("DeleterInfo")]
        [Validation(Required=false)]
        public string DeleterInfo { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the message that you want to delete. Set this parameter to the value of MsgTid that you specified when you called the SendLiveMessageGroup operation. The ID must be up to 64 bytes in length and can contain letters and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a74a8fbd3cfe4b2daa8517e4e3******</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
