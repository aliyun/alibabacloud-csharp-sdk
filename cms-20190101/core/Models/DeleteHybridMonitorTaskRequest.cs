// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>The name can contain uppercase letters, lowercase letters, digits, and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is required only if you call this operation to delete metric import tasks for Alibaba Cloud services. In this case, the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member account.</para>
        /// <remarks>
        /// <para>This parameter is required only if you use a management account to call this operation to query metric import tasks that belong to a member in a resource directory. In this case, the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

        /// <summary>
        /// <para>The ID of the metric import task.</para>
        /// <para>For information about how to obtain the ID of a metric import task, see <a href="https://help.aliyun.com/document_detail/428624.html">DescribeHybridMonitorTaskList</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only if you call this operation to delete metrics for the logs that are imported from Log Service. In this case, the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>36****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
