// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoRequest : TeaModel {
        /// <summary>
        /// <para>The task batch ID. This is the batch ID returned when callee data is imported. View the task batch ID on the <b>Call Task Management</b> &gt; <b>Details</b> &gt; <b>Execution Records</b> page, or use the batch ID returned when importing callee data by calling the <a href="https://help.aliyun.com/document_detail/2926815.html">ImportTaskNumberDatas</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139*********216</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The task detail ID. View the task detail ID in the upper-left corner of the <b>Call Task Management</b> &gt; <b>Details</b> &gt; <b>Execution Records</b> &gt; <b>Completed</b> &gt; <b>Call Details</b> page, or retrieve it by calling the <a href="https://help.aliyun.com/document_detail/2926853.html">QueryAiCallDetailPage</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9662*************</para>
        /// </summary>
        [NameInMap("DetailId")]
        [Validation(Required=false)]
        public string DetailId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task ID. View the task ID on the <b>Call Task Management</b> page or retrieve it by calling the <a href="https://help.aliyun.com/document_detail/2926799.html">QueryAiCallTaskPage</a> operation.</para>
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
