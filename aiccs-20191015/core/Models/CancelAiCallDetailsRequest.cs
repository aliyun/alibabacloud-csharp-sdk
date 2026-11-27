// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CancelAiCallDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID. This is the batch ID returned when callee data is imported. You can view the batch ID on the <b>Call task management</b> &gt; <b>Details</b> &gt; <b>Execution records</b> page, or use the batch ID returned when you call the <a href="https://help.aliyun.com/document_detail/2926815.html">ImportTaskNumberDatas</a> operation to import callee data. If the DetailIdList parameter is specified, this parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4253331213*****</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The list of task detail IDs. If this parameter is specified, it takes precedence, and the BatchId and PhoneNumbers parameters are invalid.</para>
        /// </summary>
        [NameInMap("DetailIdList")]
        [Validation(Required=false)]
        public List<string> DetailIdList { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No encryption.</description></item>
        /// <item><description>1: MD5.</description></item>
        /// <item><description>2: SHA256.</description></item>
        /// <item><description>3: SM3.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of phone numbers. To use this parameter, you must specify the BatchId parameter. Otherwise, this parameter is considered invalid.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task ID. You can view the task ID on the <b>Call task management</b> page or obtain the task ID by calling the <a href="https://help.aliyun.com/document_detail/2926799.html">QueryAiCallTaskPage</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138************</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
