// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class CreateInstanceV2Request : TeaModel {
        /// <summary>
        /// 工作空间内是否他人可见
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// 数据集集合
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<CreateInstanceV2RequestDatasets> Datasets { get; set; }
        public class CreateInstanceV2RequestDatasets : TeaModel {
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
        /// 镜像Id
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// user vpc配置
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateInstanceV2RequestUserVpc UserVpc { get; set; }
        public class CreateInstanceV2RequestUserVpc : TeaModel {
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
        /// 工作空间Id
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
