// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ModifyFlowJobRequest : TeaModel {
        /// <summary>
        /// 保留参数。
        /// </summary>
        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        /// <summary>
        /// 集群ID。您可以调用ListClusters查看集群的ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 自定义变量。
        /// </summary>
        [NameInMap("CustomVariables")]
        [Validation(Required=false)]
        public string CustomVariables { get; set; }

        /// <summary>
        /// 修改后的作业描述。
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// 需要修改的作业的ID。
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
        /// 修改后的作业名称。
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
        /// 作业内容。如果是spark作业，该参数的内容会作为spark-submit的参数。
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// 项目ID。您可以调用ListFlowProject查看项目的ID。
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 地域ID。您可以调用DescribeRegions查看最新的阿里云地域列表。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 保留参数。
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<ModifyFlowJobRequestResourceList> ResourceList { get; set; }
        public class ModifyFlowJobRequestResourceList : TeaModel {
            /// <summary>
            /// 保留参数。
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// 保留参数。
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

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

    }

}
