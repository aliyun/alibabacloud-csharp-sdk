// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class LogVMDeployMachineResponseBody : TeaModel {
        [NameInMap("deployMachineLog")]
        [Validation(Required=false)]
        public LogVMDeployMachineResponseBodyDeployMachineLog DeployMachineLog { get; set; }
        public class LogVMDeployMachineResponseBodyDeployMachineLog : TeaModel {
            [NameInMap("aliyunRegion")]
            [Validation(Required=false)]
            public string AliyunRegion { get; set; }

            [NameInMap("deployBeginTime")]
            [Validation(Required=false)]
            public long? DeployBeginTime { get; set; }

            [NameInMap("deployEndTime")]
            [Validation(Required=false)]
            public long? DeployEndTime { get; set; }

            [NameInMap("deployLog")]
            [Validation(Required=false)]
            public string DeployLog { get; set; }

            [NameInMap("deployLogPath")]
            [Validation(Required=false)]
            public string DeployLogPath { get; set; }

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
