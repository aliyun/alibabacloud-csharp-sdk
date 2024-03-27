// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class DescribeManualTaskResponseBody : TeaModel {
        /// <summary>
        /// 代表创建时间的资源属性字段
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 代表资源一级ID的资源属性字段
        /// </summary>
        [NameInMap("ManualTaskId")]
        [Validation(Required=false)]
        public string ManualTaskId { get; set; }

        /// <summary>
        /// 代表资源名称的资源属性字段
        /// </summary>
        [NameInMap("ManualTaskName")]
        [Validation(Required=false)]
        public string ManualTaskName { get; set; }

        /// <summary>
        /// 目录ID
        /// </summary>
        [NameInMap("ParentDirectoryId")]
        [Validation(Required=false)]
        public string ParentDirectoryId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 资源id列表
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

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
        /// 更新时间
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
