// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSettings : TeaModel {
        /// <summary>
        /// 作业关联用户ID
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// 调用方
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// 允许打开作业容错监控
        /// </summary>
        [NameInMap("EnableErrorMonitoringInAIMaster")]
        [Validation(Required=false)]
        public bool? EnableErrorMonitoringInAIMaster { get; set; }

        /// <summary>
        /// 允许作业使用RDMA
        /// </summary>
        [NameInMap("EnableRDMA")]
        [Validation(Required=false)]
        public bool? EnableRDMA { get; set; }

        /// <summary>
        /// 允许作业使用潮汐资源
        /// </summary>
        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        /// <summary>
        /// 用户指定容错监控的配置参数，比如指定是否启动基于log hang的检测
        /// </summary>
        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
