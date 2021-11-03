// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetRunResponseBody : TeaModel {
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
        /// 作业信息
        /// </summary>
        [NameInMap("Calls")]
        [Validation(Required=false)]
        public string Calls { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 默认runtime值
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
        /// 结束时间
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 实体对象名称
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

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
        public GetRunResponseBodyExecuteOptions ExecuteOptions { get; set; }
        public class GetRunResponseBodyExecuteOptions : TeaModel {
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
        /// 错误信息
        /// </summary>
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public string Failures { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

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
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 输出拷贝目录
        /// </summary>
        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        /// <summary>
        /// 任务输出
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 提交ID
        /// </summary>
        [NameInMap("SubmissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// 时序信息
        /// </summary>
        [NameInMap("Timing")]
        [Validation(Required=false)]
        public string Timing { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// 工作空间名字
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
