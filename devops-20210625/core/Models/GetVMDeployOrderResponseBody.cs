// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVMDeployOrderResponseBody : TeaModel {
        [NameInMap("deployOrder")]
        [Validation(Required=false)]
        public GetVMDeployOrderResponseBodyDeployOrder DeployOrder { get; set; }
        public class GetVMDeployOrderResponseBodyDeployOrder : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<GetVMDeployOrderResponseBodyDeployOrderActions> Actions { get; set; }
            public class GetVMDeployOrderResponseBodyDeployOrderActions : TeaModel {
                [NameInMap("disable")]
                [Validation(Required=false)]
                public bool? Disable { get; set; }

                [NameInMap("params")]
                [Validation(Required=false)]
                public object Params { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
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
                [NameInMap("batchNum")]
                [Validation(Required=false)]
                public int? BatchNum { get; set; }

                [NameInMap("deployMachines")]
                [Validation(Required=false)]
                public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines> DeployMachines { get; set; }
                public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines : TeaModel {
                    [NameInMap("actions")]
                    [Validation(Required=false)]
                    public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions> Actions { get; set; }
                    public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions : TeaModel {
                        [NameInMap("disable")]
                        [Validation(Required=false)]
                        public bool? Disable { get; set; }

                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public object Params { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("batchNum")]
                    [Validation(Required=false)]
                    public int? BatchNum { get; set; }

                    [NameInMap("clientStatus")]
                    [Validation(Required=false)]
                    public string ClientStatus { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    [NameInMap("machineSn")]
                    [Validation(Required=false)]
                    public string MachineSn { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("updateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

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

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
