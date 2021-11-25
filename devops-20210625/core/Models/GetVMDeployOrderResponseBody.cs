// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVMDeployOrderResponseBody : TeaModel {
        /// <summary>
        /// 部署单
        /// </summary>
        [NameInMap("deployOrder")]
        [Validation(Required=false)]
        public GetVMDeployOrderResponseBodyDeployOrder DeployOrder { get; set; }
        public class GetVMDeployOrderResponseBodyDeployOrder : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<GetVMDeployOrderResponseBodyDeployOrderActions> Actions { get; set; }
            public class GetVMDeployOrderResponseBodyDeployOrderActions : TeaModel {
                public bool? Disable { get; set; }
                public Dictionary<string, string> Params { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("currentBatch")]
            [Validation(Required=false)]
            public int? CurrentBatch { get; set; }
            [NameInMap("deployMachineInfo")]
            [Validation(Required=false)]
            public GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfo DeployMachineInfo { get; set; }
            public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfo : TeaModel {
                /// <summary>
                /// 发布批次
                /// </summary>
                [NameInMap("batchNum")]
                [Validation(Required=false)]
                public int? BatchNum { get; set; }

                /// <summary>
                /// 部署机器列表
                /// </summary>
                [NameInMap("deployMachines")]
                [Validation(Required=false)]
                public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines> DeployMachines { get; set; }
                public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines : TeaModel {
                    /// <summary>
                    /// 后续action
                    /// </summary>
                    [NameInMap("actions")]
                    [Validation(Required=false)]
                    public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions> Actions { get; set; }
                    public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions : TeaModel {
                        /// <summary>
                        /// 是否可用
                        /// </summary>
                        [NameInMap("disable")]
                        [Validation(Required=false)]
                        public bool? Disable { get; set; }

                        /// <summary>
                        /// 参数
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Params { get; set; }

                        /// <summary>
                        /// Action
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// 部署批次
                    /// </summary>
                    [NameInMap("batchNum")]
                    [Validation(Required=false)]
                    public int? BatchNum { get; set; }

                    /// <summary>
                    /// 机器状态
                    /// </summary>
                    [NameInMap("clientStatus")]
                    [Validation(Required=false)]
                    public string ClientStatus { get; set; }

                    /// <summary>
                    /// 开始时间
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// 机器IP
                    /// </summary>
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// 机器sn
                    /// </summary>
                    [NameInMap("machineSn")]
                    [Validation(Required=false)]
                    public string MachineSn { get; set; }

                    /// <summary>
                    /// 部署状态
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// 修改时间
                    /// </summary>
                    [NameInMap("updateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

                /// <summary>
                /// 主机组ID
                /// </summary>
                [NameInMap("hostGroupId")]
                [Validation(Required=false)]
                public long? HostGroupId { get; set; }

            }
            [NameInMap("deployOrderId")]
            [Validation(Required=false)]
            public string DeployOrderId { get; set; }
            [NameInMap("exceptionCode")]
            [Validation(Required=false)]
            public string ExceptionCode { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("totalBatch")]
            [Validation(Required=false)]
            public int? TotalBatch { get; set; }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
