// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CancelAiCallDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID. This ID is returned when you import callee data. You can find the task batch ID on the <b>Call Task Management</b>&gt;<b>Details</b>&gt;<b>Execution Record</b> page, or use the import batch ID that is returned by the <a href="https://help.aliyun.com/document_detail/2926815.html">ImportTaskNumberDatas</a> API operation. If DetailIdList is specified, this parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4253331213*****</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>A list of detail IDs. If you specify this parameter, <c>BatchId</c> and <c>PhoneNumbers</c> are ignored.</para>
        /// </summary>
        [NameInMap("DetailIdList")]
        [Validation(Required=false)]
        public List<string> DetailIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>A list of phone numbers. This parameter takes effect only when <c>BatchId</c> is also specified.</para>
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
        /// <para>The task ID. You can view the task ID on the <b>Call Task Management</b> page or obtain it by calling the <a href="https://help.aliyun.com/document_detail/2926799.html">QueryAiCallTaskPage</a> operation.</para>
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
