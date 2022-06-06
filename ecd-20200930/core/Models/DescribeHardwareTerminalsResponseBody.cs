// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeHardwareTerminalsResponseBody : TeaModel {
        [NameInMap("HardwareTerminals")]
        [Validation(Required=false)]
        public List<DescribeHardwareTerminalsResponseBodyHardwareTerminals> HardwareTerminals { get; set; }
        public class DescribeHardwareTerminalsResponseBodyHardwareTerminals : TeaModel {
            [NameInMap("HardwareType")]
            [Validation(Required=false)]
            public string HardwareType { get; set; }

            [NameInMap("HardwareTypeDetails")]
            [Validation(Required=false)]
            public List<DescribeHardwareTerminalsResponseBodyHardwareTerminalsHardwareTypeDetails> HardwareTypeDetails { get; set; }
            public class DescribeHardwareTerminalsResponseBodyHardwareTerminalsHardwareTypeDetails : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HardwareVersion")]
                [Validation(Required=false)]
                public int? HardwareVersion { get; set; }

                [NameInMap("StockState")]
                [Validation(Required=false)]
                public string StockState { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
