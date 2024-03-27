// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class ListTaskInstancesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTaskInstancesResponseBodyData> Data { get; set; }
        public class ListTaskInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// 空跑标识
            /// </summary>
            [NameInMap("DryRun")]
            [Validation(Required=false)]
            public string DryRun { get; set; }

            /// <summary>
            /// EMR集群ID
            /// </summary>
            [NameInMap("EmrClusterId")]
            [Validation(Required=false)]
            public string EmrClusterId { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 外部应用ID
            /// </summary>
            [NameInMap("ExternalAppId")]
            [Validation(Required=false)]
            public string ExternalAppId { get; set; }

            /// <summary>
            /// 资源组ID
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// 重试次数
            /// </summary>
            [NameInMap("RetryTimes")]
            [Validation(Required=false)]
            public int? RetryTimes { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 提交时间
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// 任务ID
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 任务实例ID
            /// </summary>
            [NameInMap("TaskInstanceId")]
            [Validation(Required=false)]
            public string TaskInstanceId { get; set; }

            /// <summary>
            /// 任务实例名称
            /// </summary>
            [NameInMap("TaskInstanceName")]
            [Validation(Required=false)]
            public string TaskInstanceName { get; set; }

            /// <summary>
            /// 任务参数
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// 任务类型
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// 任务版本
            /// </summary>
            [NameInMap("TaskVersion")]
            [Validation(Required=false)]
            public string TaskVersion { get; set; }

            /// <summary>
            /// 工作流实例ID
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public string WorkflowInstanceId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
