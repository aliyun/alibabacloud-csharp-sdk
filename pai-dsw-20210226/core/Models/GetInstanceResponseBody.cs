// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// 累计运行时间(分钟)
        /// </summary>
        [NameInMap("AccumulativeRunningTimeInMinutes")]
        [Validation(Required=false)]
        public long? AccumulativeRunningTimeInMinutes { get; set; }

        /// <summary>
        /// ecs规格
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// 实例创建时间(GMT)
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 实例修改时间(GMT)
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像链接
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 定时关机任务
        /// </summary>
        [NameInMap("InstanceShutdownTimer")]
        [Validation(Required=false)]
        public InstanceShutdownTimer InstanceShutdownTimer { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// jupyter链接
        /// </summary>
        [NameInMap("JupyterlabUrl")]
        [Validation(Required=false)]
        public string JupyterlabUrl { get; set; }

        /// <summary>
        /// nas文件系统ID
        /// </summary>
        [NameInMap("NasFileSystemId")]
        [Validation(Required=false)]
        public string NasFileSystemId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 命令行终端链接
        /// </summary>
        [NameInMap("TerminalUrl")]
        [Validation(Required=false)]
        public string TerminalUrl { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 被打通VPC配置
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        /// <summary>
        /// web ide链接
        /// </summary>
        [NameInMap("WebIdeUrl")]
        [Validation(Required=false)]
        public string WebIdeUrl { get; set; }

    }

}
