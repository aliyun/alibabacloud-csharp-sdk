// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListRequest : TeaModel {
        /// <summary>
        /// The additional information of the instance.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The timestamp when the metric import task was created.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("IncludeAliyunTask")]
        [Validation(Required=false)]
        public bool? IncludeAliyunTask { get; set; }

        /// <summary>
        /// The conditions that are used to filter logs imported from Log Service.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.
        /// 
        /// *   namespace: the namespace of the Alibaba Cloud service.
        /// *   metric_list: the metrics of the Alibaba Cloud service.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeHybridMonitorTaskList**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The keyword that is used to search for metric import tasks.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// The type of the metric import task. Valid values:
        /// 
        /// *   aliyun_fc: metric import tasks for Alibaba Cloud services
        /// *   aliyun_sls: metrics for logs imported from Log Service
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The interval at which the CloudMonitor agent collects host monitoring data. Valid values:
        /// 
        /// *   15
        /// *   30
        /// *   60
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
