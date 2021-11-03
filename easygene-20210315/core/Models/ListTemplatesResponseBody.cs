// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 最大返回结果
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 下次查询Token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 应用模板列表
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// 应用名称
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// 应用版本
            /// </summary>
            [NameInMap("AppRevision")]
            [Validation(Required=false)]
            public string AppRevision { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 模板描述信息
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 应用输入
            /// </summary>
            [NameInMap("InputsExpression")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyTemplatesInputsExpression> InputsExpression { get; set; }
            public class ListTemplatesResponseBodyTemplatesInputsExpression : TeaModel {
                /// <summary>
                /// 帮助信息
                /// </summary>
                [NameInMap("Help")]
                [Validation(Required=false)]
                public string Help { get; set; }

                /// <summary>
                /// 是否必须参数
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
            /// 标签
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// 最后修改时间
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// 应用的输出参数
            /// </summary>
            [NameInMap("OutputsExpression")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyTemplatesOutputsExpression> OutputsExpression { get; set; }
            public class ListTemplatesResponseBodyTemplatesOutputsExpression : TeaModel {
                /// <summary>
                /// 帮助信息
                /// </summary>
                [NameInMap("Help")]
                [Validation(Required=false)]
                public string Help { get; set; }

                /// <summary>
                /// 是否必须参数
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
            /// 实体类型
            /// </summary>
            [NameInMap("RootEntity")]
            [Validation(Required=false)]
            public string RootEntity { get; set; }

            /// <summary>
            /// 应用模板名称
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// 工作空间
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// 返回个数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
