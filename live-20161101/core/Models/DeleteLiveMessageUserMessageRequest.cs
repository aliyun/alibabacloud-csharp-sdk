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
        /// <para>The data center where the interactive messaging application is deployed. Set this parameter to the value of DataCenter that you specified when you called the <a href="https://help.aliyun.com/document_detail/2593195.html">CreateLiveMessageApp</a> operation. Valid values: cn-shanghai (Shanghai) and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the deletion operation. The ID can contain only letters and digits and can be up to 64 bytes in length.</para>
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
        /// <para>username</para>
        /// </summary>
        [NameInMap("DeleterInfo")]
        [Validation(Required=false)]
        public string DeleterInfo { get; set; }

        /// <summary>
        /// <para>The ID of the message that you want to delete. Set this parameter to the value of MsgTid that you specified when you called the SendLiveMessageUser operation. The ID can contain only letters and digits and can be up to 64 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The ID of the user who received the message to delete. The ID can contain only letters and digits and can be up to 64 bytes in length.</para>
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
