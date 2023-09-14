// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunApplicationActionRequest : TeaModel {
        /// <summary>
        /// 操作名称。取值范围：
        /// - start：启动。
        /// - stop：停止。
        /// - config: 下发配置。
        /// - refresh_queues: 刷新yarn队列。
        /// 等
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// 每批数量。
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 组件实例选择器。
        /// </summary>
        [NameInMap("ComponentInstanceSelector")]
        [Validation(Required=false)]
        public ComponentInstanceSelector ComponentInstanceSelector { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 运行失败策略。取值范围：
        /// - FAILED_BLOCK：失败后阻塞。
        /// - FAILED_CONTINUE：失败后继续。
        /// </summary>
        [NameInMap("ExecuteStrategy")]
        [Validation(Required=false)]
        public string ExecuteStrategy { get; set; }

        /// <summary>
        /// 滚动执行间隔时间。
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 是否滚动执行。
        /// </summary>
        [NameInMap("RollingExecute")]
        [Validation(Required=false)]
        public bool? RollingExecute { get; set; }

    }

}
