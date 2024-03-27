// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyData> Data { get; set; }
        public class ListTasksResponseBodyData : TeaModel {
            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 延时执行时间
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public int? DelayTime { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 失败重试间隔
            /// </summary>
            [NameInMap("FailRetryInterval")]
            [Validation(Required=false)]
            public int? FailRetryInterval { get; set; }

            /// <summary>
            /// 失败重试次数
            /// </summary>
            [NameInMap("FailRetryTimes")]
            [Validation(Required=false)]
            public int? FailRetryTimes { get; set; }

            /// <summary>
            /// 运行标志
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// 项目ID
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 资源ID列表
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public string ResourceIds { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// 任务参数
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// 任务优先级
            /// </summary>
            [NameInMap("TaskPriority")]
            [Validation(Required=false)]
            public string TaskPriority { get; set; }

            /// <summary>
            /// 任务类型
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// 超时时长
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// 超时告警标志
            /// </summary>
            [NameInMap("TimeoutFlag")]
            [Validation(Required=false)]
            public string TimeoutFlag { get; set; }

            /// <summary>
            /// 超时告警标志
            /// </summary>
            [NameInMap("TimeoutNotifyStrategy")]
            [Validation(Required=false)]
            public string TimeoutNotifyStrategy { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// 版本
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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
