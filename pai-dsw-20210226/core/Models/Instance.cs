// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class Instance : TeaModel {
        /// <summary>
        /// 运行时间，毫秒数
        /// </summary>
        [NameInMap("AccumulativeRunningTimeInMillis")]
        [Validation(Required=false)]
        public long? AccumulativeRunningTimeInMillis { get; set; }

        /// <summary>
        /// 累计运行时间(分钟)
        /// </summary>
        [NameInMap("AccumulativeRunningTimeInMinutes")]
        [Validation(Required=false)]
        public long? AccumulativeRunningTimeInMinutes { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [NameInMap("CreateUser")]
        [Validation(Required=false)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 数据集列表
        /// </summary>
        [NameInMap("DatasetList")]
        [Validation(Required=false)]
        public List<Dataset> DatasetList { get; set; }

        /// <summary>
        /// ecs规格
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// 创建时间(GMT)
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 修改时间(GMT)
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
        /// 镜像名称
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像类型
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

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
        /// dsw实例链接
        /// </summary>
        [NameInMap("InstanceUrl")]
        [Validation(Required=false)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// 实例版本
        /// </summary>
        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// 是否他人可见
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public long? IsPublic { get; set; }

        /// <summary>
        /// jupyter链接
        /// </summary>
        [NameInMap("JupyterlabUrl")]
        [Validation(Required=false)]
        public string JupyterlabUrl { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// nas文件系统ID
        /// </summary>
        [NameInMap("NasFileSystemId")]
        [Validation(Required=false)]
        public string NasFileSystemId { get; set; }

        /// <summary>
        /// 付费类型代码
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public long? PayType { get; set; }

        /// <summary>
        /// 付费类型名称
        /// </summary>
        [NameInMap("PayTypeName")]
        [Validation(Required=false)]
        public string PayTypeName { get; set; }

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// 资源类型代码
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// 是否支持定时关机
        /// </summary>
        [NameInMap("ShutdownEnabled")]
        [Validation(Required=false)]
        public bool? ShutdownEnabled { get; set; }

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
        /// 保存用户镜像列表
        /// </summary>
        [NameInMap("UserImageList")]
        [Validation(Required=false)]
        public List<Image> UserImageList { get; set; }

        /// <summary>
        /// 被打通VPC配置
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        /// <summary>
        /// webIde链接
        /// </summary>
        [NameInMap("WebIdeUrl")]
        [Validation(Required=false)]
        public string WebIdeUrl { get; set; }

        /// <summary>
        /// 工作空间id
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
