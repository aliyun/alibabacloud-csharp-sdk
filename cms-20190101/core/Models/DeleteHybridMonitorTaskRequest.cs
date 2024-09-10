// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// The name of the namespace.
        /// 
        /// The name can contain uppercase letters, lowercase letters, digits, and hyphens (-).
        /// 
        /// > This parameter is required only if you call this operation to delete metric import tasks for Alibaba Cloud services. In this case, the `TaskType` parameter is set to `aliyun_fc`.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the member account.
        /// 
        /// > This parameter is required only if you use a management account to call this operation to query metric import tasks that belong to a member in a resource directory. In this case, the `TaskType` parameter is set to `aliyun_fc`.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

        /// <summary>
        /// The ID of the metric import task.
        /// 
        /// For information about how to obtain the ID of a metric import task, see [DescribeHybridMonitorTaskList](https://help.aliyun.com/document_detail/428624.html).
        /// 
        /// > This parameter is required only if you call this operation to delete metrics for the logs that are imported from Log Service. In this case, the `TaskType` parameter is set to `aliyun_sls`.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
