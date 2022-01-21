// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeFlowJobResponseBody : TeaModel {
        /// <summary>
        /// 是否临时查询。
        /// </summary>
        [NameInMap("Adhoc")]
        [Validation(Required=false)]
        public string Adhoc { get; set; }

        /// <summary>
        /// 报警配置。
        /// </summary>
        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        /// <summary>
        /// 作业所在目录ID。
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 自定义变量。
        /// </summary>
        [NameInMap("CustomVariables")]
        [Validation(Required=false)]
        public string CustomVariables { get; set; }

        /// <summary>
        /// 作业的描述。
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 保留参数。
        /// </summary>
        [NameInMap("EditLockDetail")]
        [Validation(Required=false)]
        public string EditLockDetail { get; set; }

        /// <summary>
        /// 环境变量设置。
        /// </summary>
        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConf { get; set; }

        /// <summary>
        /// 失败策略，可能的取值：CONTINUE（提过本次作业），STOP（停止作业）
        /// </summary>
        [NameInMap("FailAct")]
        [Validation(Required=false)]
        public string FailAct { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间。
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// 作业ID。
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// Knox的用户密码，执行Zeppelin Notebook时必须提供。
        /// </summary>
        [NameInMap("KnoxPassword")]
        [Validation(Required=false)]
        public string KnoxPassword { get; set; }

        /// <summary>
        /// Knox的用户名，执行Zeppelin Notebook时必须提供。
        /// </summary>
        [NameInMap("KnoxUser")]
        [Validation(Required=false)]
        public string KnoxUser { get; set; }

        /// <summary>
        /// 最后一次执行的实例ID。
        /// </summary>
        [NameInMap("LastInstanceId")]
        [Validation(Required=false)]
        public string LastInstanceId { get; set; }

        /// <summary>
        /// 最大重试次数。
        /// </summary>
        [NameInMap("MaxRetry")]
        [Validation(Required=false)]
        public int? MaxRetry { get; set; }

        /// <summary>
        /// 保留参数。
        /// </summary>
        [NameInMap("MaxRunningTimeSec")]
        [Validation(Required=false)]
        public long? MaxRunningTimeSec { get; set; }

        /// <summary>
        /// 模型模式，取值如下：  YARN：将作业包装成一个Launcher提交至YARN中执行，LOCAL：作业直接在机器上以进程方式运行。
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// 监控配置，仅SPARK_STREAMING类型作业支持监控配置。
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConf { get; set; }

        /// <summary>
        /// 作业名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 参数设置。
        /// </summary>
        [NameInMap("ParamConf")]
        [Validation(Required=false)]
        public string ParamConf { get; set; }

        /// <summary>
        /// 作业内容。
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public DescribeFlowJobResponseBodyResourceList ResourceList { get; set; }
        public class DescribeFlowJobResponseBodyResourceList : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeFlowJobResponseBodyResourceListResource> Resource { get; set; }
            public class DescribeFlowJobResponseBodyResourceListResource : TeaModel {
                public string Alias { get; set; }
                public string Path { get; set; }
            }
        };

        /// <summary>
        /// 重试间隔 0~300（秒）。
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public long? RetryInterval { get; set; }

        /// <summary>
        /// 重试策略，保留参数。
        /// </summary>
        [NameInMap("RetryPolicy")]
        [Validation(Required=false)]
        public string RetryPolicy { get; set; }

        /// <summary>
        /// 运行配置，取值如下：priority（优先级），userName（任务的Linux提交用户），memory（内存，单位为MB），cores（核数）
        /// </summary>
        [NameInMap("RunConf")]
        [Validation(Required=false)]
        public string RunConf { get; set; }

        /// <summary>
        /// 作业的类型，可能的取值有：SPARK，SPARK_STREAMING，ZEPPELIN
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
