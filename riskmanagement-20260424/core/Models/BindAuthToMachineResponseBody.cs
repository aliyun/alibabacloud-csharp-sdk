// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class BindAuthToMachineResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindAuthToMachineResponseBodyData Data { get; set; }
        public class BindAuthToMachineResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public BindAuthToMachineResponseBodyDataBody Body { get; set; }
            public class BindAuthToMachineResponseBodyDataBody : TeaModel {
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public int? BindCount { get; set; }

                [NameInMap("InsufficientCoreCount")]
                [Validation(Required=false)]
                public int? InsufficientCoreCount { get; set; }

                [NameInMap("InsufficientEcsCount")]
                [Validation(Required=false)]
                public int? InsufficientEcsCount { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                [NameInMap("UnBindCount")]
                [Validation(Required=false)]
                public int? UnBindCount { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
