// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendLiveMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application in which the message is received.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The message body. The body can be up to 15 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello,group</para>
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
        /// <para>The ID of the group that receives the message.</para>
        /// <remarks>
        /// <para> Make sure that the specified group ID exists. Otherwise, a ResourceNotExist error is returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public long? MsgType { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable message caching. Valid values: true and false. Default value: false, which specifies that the message is cached to the recent message list of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoCache")]
        [Validation(Required=false)]
        public bool? NoCache { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable message storage. Valid values: true and false. Default value: false, which specifies that the message is stored for a validity period of 30 days. You can find the message in the response of the ListLiveMessageGroupMessages operation. If you do not want to store the message, set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoStorage")]
        [Validation(Required=false)]
        public bool? NoStorage { get; set; }

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
        /// <para>The additional information about the user who sends the message. The value can be up to 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1meta1</para>
        /// </summary>
        [NameInMap("SenderMetaInfo")]
        [Validation(Required=false)]
        public string SenderMetaInfo { get; set; }

        /// <summary>
        /// <para>The contribution of the message to the increase in the number of messages of this type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StaticsIncrease")]
        [Validation(Required=false)]
        public long? StaticsIncrease { get; set; }

        /// <summary>
        /// <para>The weight of the message. Default value: 1. A greater value indicates a higher priority. For a message of the highest priority, you can set the weight to 1000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

    }

}
