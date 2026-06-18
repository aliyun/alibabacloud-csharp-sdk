// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListDialogRequest : TeaModel {
        /// <summary>
        /// <para>The called number. You can view the called number in the <a href="https://aiccs.console.aliyun.com/job/list"><b>Task Management</b></a> &gt; <b>Details</b> interface or retrieve it by invoking the <a href="https://help.aliyun.com/document_detail/2718009.html">ListTaskDetail</a> API. The <b>Called</b> parameter in the API response is the called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130****0000</para>
        /// </summary>
        [NameInMap("Called")]
        [Validation(Required=false)]
        public string Called { get; set; }

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
        /// <para>The unique job ID of the robot outbound call task. You can view it in the <a href="https://aiccs.console.aliyun.com/job/list">Task Management</a> interface or obtain it by invoking the <a href="https://help.aliyun.com/document_detail/223556.html">CreateTask</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
