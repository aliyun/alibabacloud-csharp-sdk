// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// 任务当前状态。
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务执行详情。
        /// </summary>
        [NameInMap("task_result")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyTaskResult> TaskResult { get; set; }
        public class DescribeTaskInfoResponseBodyTaskResult : TeaModel {
            /// <summary>
            /// 操作的资源，例如：实例ID。
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// 资源的状态。
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 当前任务类型。
        /// </summary>
        [NameInMap("task_type")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务更新时间。
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

    }

}
