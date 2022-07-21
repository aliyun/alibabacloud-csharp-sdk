// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobItem : TeaModel {
        /// <summary>
        /// 代码源配置
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public JobItemCodeSource CodeSource { get; set; }
        public class JobItemCodeSource : TeaModel {
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
        public List<JobItemDataSources> DataSources { get; set; }
        public class JobItemDataSources : TeaModel {
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
        /// 作业显示名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 作业运行时长，单位：秒
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// 是否开启了debugger分析
        /// </summary>
        [NameInMap("EnabledDebugger")]
        [Validation(Required=false)]
        public bool? EnabledDebugger { get; set; }

        /// <summary>
        /// 环境变量配置
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// 作业创建时间（UTC）
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 作业结束时间（UTC）
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// 作业Id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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

        /// <summary>
        /// 状态详情码
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 状态详情
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// 作业运行所在的资源组ID
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 作业运行时的资源级别
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// 作业运行的资源名称
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 作业额外参数
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// 作业状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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
        /// 用户命令
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// 作业提交人Id
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 作业所属工作空间ID
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 作业所属工作空间名称
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
