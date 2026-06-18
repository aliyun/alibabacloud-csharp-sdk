// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoNewRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1552<b><b><b><b>^1420</b></b></b></b></para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The task detail ID. View the task detail ID in the upper-left corner of the <b>Call Task Management</b> &gt; <b>Details</b> &gt; <b>Execution Records</b> &gt; <b>Completed</b> &gt; <b>Call Details</b> console, or call the <a href="https://help.aliyun.com/document_detail/2926853.html">QueryAiCallDetailPage</a> operation to obtain the task detail ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9662*************</para>
        /// </summary>
        [NameInMap("DetailId")]
        [Validation(Required=false)]
        public string DetailId { get; set; }

        /// <summary>
        /// <para>The external business serial number reserved for external input. You can use a unique ID for business association.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123******</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

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
        /// <para>The task ID. View the task ID in the <b>Call Task Management</b> console or call the <a href="https://help.aliyun.com/document_detail/2926799.html">QueryAiCallTaskPage</a> operation to obtain the task ID.</para>
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
