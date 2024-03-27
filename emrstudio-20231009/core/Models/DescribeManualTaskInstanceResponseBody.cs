// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class DescribeManualTaskInstanceResponseBody : TeaModel {
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
        /// 代表资源一级ID的资源属性字段
        /// </summary>
        [NameInMap("ManualTaskInstanceId")]
        [Validation(Required=false)]
        public string ManualTaskInstanceId { get; set; }

        /// <summary>
        /// 代表资源名称的资源属性字段
        /// </summary>
        [NameInMap("ManualTaskInstanceName")]
        [Validation(Required=false)]
        public string ManualTaskInstanceName { get; set; }

        /// <summary>
        /// 资源组ID
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
