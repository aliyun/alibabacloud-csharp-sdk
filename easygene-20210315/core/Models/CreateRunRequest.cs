// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateRunRequest : TeaModel {
        /// <summary>
        /// 应用名称
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        /// <summary>
        /// 任务幂等token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 默认运行时
        /// </summary>
        [NameInMap("DefaultRuntime")]
        [Validation(Required=false)]
        public string DefaultRuntime { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 任务执行目录
        /// </summary>
        [NameInMap("ExecuteDirectory")]
        [Validation(Required=false)]
        public string ExecuteDirectory { get; set; }

        /// <summary>
        /// 任务配置
        /// </summary>
        [NameInMap("ExecuteOptions")]
        [Validation(Required=false)]
        public CreateRunRequestExecuteOptions ExecuteOptions { get; set; }
        public class CreateRunRequestExecuteOptions : TeaModel {
            [NameInMap("CallCaching")]
            [Validation(Required=false)]
            public bool? CallCaching { get; set; }
            [NameInMap("DeleteIntermediateResults")]
            [Validation(Required=false)]
            public bool? DeleteIntermediateResults { get; set; }
            [NameInMap("FailureMode")]
            [Validation(Required=false)]
            public string FailureMode { get; set; }
            [NameInMap("UseRelativeOutputPaths")]
            [Validation(Required=false)]
            public bool? UseRelativeOutputPaths { get; set; }
        };

        /// <summary>
        /// 任务输入
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        /// <summary>
        /// 任务标签
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// 任务输出拷贝目录
        /// </summary>
        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// 工作空间名字
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
