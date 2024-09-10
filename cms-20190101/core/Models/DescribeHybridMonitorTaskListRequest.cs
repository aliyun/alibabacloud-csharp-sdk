// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Specifies whether the returned result includes metric import tasks for Alibaba Cloud services. Valid values:
        /// 
        /// *   true (default): The returned result includes metric import tasks for Alibaba Cloud services.
        /// *   false: The returned result excludes metric import tasks for Alibaba Cloud services.
        /// </summary>
        [NameInMap("IncludeAliyunTask")]
        [Validation(Required=false)]
        public bool? IncludeAliyunTask { get; set; }

        /// <summary>
        /// The keyword that is used for the search.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](https://help.aliyun.com/document_detail/428880.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Pages start from page 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the member account.
        /// 
        /// > This parameter is required only if you use a management account to call this operation to delete the metric import tasks that belong to a member in a resource directory. In this case, the `TaskType` parameter is set to `aliyun_fc`.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// The ID of the metric import task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The type of the metric import task. Valid values:
        /// 
        /// *   aliyun_fc: metric import tasks for Alibaba Cloud services
        /// *   aliyun_sls: metrics for logs imported from Log Service
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
