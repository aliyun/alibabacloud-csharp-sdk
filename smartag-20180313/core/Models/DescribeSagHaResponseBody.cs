// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagHaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagHaResponseBodyPorts> Ports { get; set; }
        public class DescribeSagHaResponseBodyPorts : TeaModel {
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("VirtualIp")]
            [Validation(Required=false)]
            public string VirtualIp { get; set; }

        }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagHaResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagHaResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
