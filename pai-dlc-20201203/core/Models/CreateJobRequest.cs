// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// 代码源配置
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public CreateJobRequestCodeSource CodeSource { get; set; }
        public class CreateJobRequestCodeSource : TeaModel {
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }
        };

        /// <summary>
        /// 数据源配置列表
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<CreateJobRequestDataSources> DataSources { get; set; }
        public class CreateJobRequestDataSources : TeaModel {
            /// <summary>
            /// 数据源Id
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// 本地挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        /// <summary>
        /// debugger参数
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// 作业显示名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("ElasticSpec")]
        [Validation(Required=false)]
        public JobElasticSpec ElasticSpec { get; set; }

        /// <summary>
        /// 环境变量配置
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// 作业最大运行时间
        /// </summary>
        [NameInMap("JobMaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? JobMaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// 作业规格配置
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// 作业类型
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// 作业优先级
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 资源组编号
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// 三方库(requirements.txt)文件路径
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// 三方库配置列表
        /// </summary>
        [NameInMap("ThirdpartyLibs")]
        [Validation(Required=false)]
        public List<string> ThirdpartyLibs { get; set; }

        /// <summary>
        /// 作业命令
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// 用户VPC
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateJobRequestUserVpc UserVpc { get; set; }
        public class CreateJobRequestUserVpc : TeaModel {
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

        /// <summary>
        /// 工作空间编号
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
