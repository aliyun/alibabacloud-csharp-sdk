// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetAppResponseBody : TeaModel {
        /// <summary>
        /// 应用名称
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 参考输入
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyConfigs> Configs { get; set; }
        public class GetAppResponseBodyConfigs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 应用定义
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// 依赖应用
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyDependencies> Dependencies { get; set; }
        public class GetAppResponseBodyDependencies : TeaModel {
            /// <summary>
            /// wdl内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 依赖路径
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// 应用简要描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 应用详细文档
        /// </summary>
        [NameInMap("Documentation")]
        [Validation(Required=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 应用输入
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyInputs> Inputs { get; set; }
        public class GetAppResponseBodyInputs : TeaModel {
            /// <summary>
            /// 帮助
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// 是否必须
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// 步骤顺序
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            /// <summary>
            /// 任务名称
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// 变量名称
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// 变量类型
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// 变量值
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// 应用标签
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 应用描述语言
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// 应用描述语言版本
        /// </summary>
        [NameInMap("LanguageVersion")]
        [Validation(Required=false)]
        public string LanguageVersion { get; set; }

        /// <summary>
        /// 应用最后修改时间
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// 应用的输出参数
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyOutputs> Outputs { get; set; }
        public class GetAppResponseBodyOutputs : TeaModel {
            /// <summary>
            /// 帮助信息
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// 是否必须
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// 步骤编号
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            /// <summary>
            /// 任务名称
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// 参数名称
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// 参数类型
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// 参数值
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// 主WDL路径
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [NameInMap("Revision")]
        [Validation(Required=false)]
        public string Revision { get; set; }

        /// <summary>
        /// 应用当前版本修改
        /// </summary>
        [NameInMap("RevisionComment")]
        [Validation(Required=false)]
        public string RevisionComment { get; set; }

        /// <summary>
        /// 应用的所有版本号
        /// </summary>
        [NameInMap("Revisions")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyRevisions> Revisions { get; set; }
        public class GetAppResponseBodyRevisions : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            /// <summary>
            /// 应用当前版本修改
            /// </summary>
            [NameInMap("RevisionComment")]
            [Validation(Required=false)]
            public string RevisionComment { get; set; }

        }

        /// <summary>
        /// 应用可见范围
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 应用URL
        /// </summary>
        [NameInMap("URL")]
        [Validation(Required=false)]
        public string URL { get; set; }

        /// <summary>
        /// 工作流名称
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
