// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagPortListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagPortListResponseBodyPorts> Ports { get; set; }
        public class DescribeSagPortListResponseBodyPorts : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

        }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagPortListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagPortListResponseBodyTaskStates : TeaModel {
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
