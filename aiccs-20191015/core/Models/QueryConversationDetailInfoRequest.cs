// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID. This ID is returned by the <a href="https://help.aliyun.com/document_detail/2926815.html">ImportTaskNumberDatas</a> operation when you import callee data. You can view this ID on the <b>execution history</b> page by navigating to <b>call task management</b> &gt; <b>details</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139*********216</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The detail ID. You can find this ID in the upper-left corner of the page by navigating to <b>call task management</b> &gt; <b>details</b> &gt; <b>execution history</b> &gt; <b>completed</b> &gt; <b>call details</b>, or get it by calling the <a href="https://help.aliyun.com/document_detail/2926853.html">QueryAiCallDetailPage</a> operation.</para>
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
        /// <para>The task ID. You can find this ID on the <b>call task management</b> page or get it by calling the <a href="https://help.aliyun.com/document_detail/2926799.html">QueryAiCallTaskPage</a> operation.</para>
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
