// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class UpdateInstanceV2Request : TeaModel {
        /// <summary>
        /// 实例计算类型
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// 工作空间内是否他人可见
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// 累计运行时间（ms）
        /// </summary>
        [NameInMap("AccumulatedRunningTimeInMs")]
        [Validation(Required=false)]
        public long? AccumulatedRunningTimeInMs { get; set; }

        /// <summary>
        /// 数据集集合
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<UpdateInstanceV2RequestDatasets> Datasets { get; set; }
        public class UpdateInstanceV2RequestDatasets : TeaModel {
            /// <summary>
            /// 数据集Id
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// 容器内挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        /// <summary>
        /// 实例对应的Ecs规格
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 实例修改时间
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// 镜像Id
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
        /// 镜像地址
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例Id
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
        public UpdateInstanceV2RequestInstanceShutdownTimer InstanceShutdownTimer { get; set; }
        public class UpdateInstanceV2RequestInstanceShutdownTimer : TeaModel {
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RemainingTimeInMs")]
            [Validation(Required=false)]
            public long? RemainingTimeInMs { get; set; }
        };

        /// <summary>
        /// 实例Url
        /// </summary>
        [NameInMap("InstanceUrl")]
        [Validation(Required=false)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// Jupyterlab Url
        /// </summary>
        [NameInMap("JupyterlabUrl")]
        [Validation(Required=false)]
        public string JupyterlabUrl { get; set; }

        /// <summary>
        /// 最新保存的用户镜像
        /// </summary>
        [NameInMap("LatestSnapshot")]
        [Validation(Required=false)]
        public UpdateInstanceV2RequestLatestSnapshot LatestSnapshot { get; set; }
        public class UpdateInstanceV2RequestLatestSnapshot : TeaModel {
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
            [NameInMap("RepositoryUrl")]
            [Validation(Required=false)]
            public string RepositoryUrl { get; set; }
        };

        /// <summary>
        /// 支付类型
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 实例错误代码
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 实例错误原因
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// terminal url
        /// </summary>
        [NameInMap("TerminalUrl")]
        [Validation(Required=false)]
        public string TerminalUrl { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// user vpc配置
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UpdateInstanceV2RequestUserVpc UserVpc { get; set; }
        public class UpdateInstanceV2RequestUserVpc : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

        /// <summary>
        /// web ide url
        /// </summary>
        [NameInMap("WebIDEUrl")]
        [Validation(Required=false)]
        public string WebIDEUrl { get; set; }

        /// <summary>
        /// 工作空间Id
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
