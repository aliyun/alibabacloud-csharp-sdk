// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeDriverResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("DriverList")]
        [Validation(Required=false)]
        public List<BatchGetEdgeDriverResponseBodyDriverList> DriverList { get; set; }
        public class BatchGetEdgeDriverResponseBodyDriverList : TeaModel {
            [NameInMap("DriverId")]
            [Validation(Required=false)]
            public string DriverId { get; set; }

            [NameInMap("DriverName")]
            [Validation(Required=false)]
            public string DriverName { get; set; }

            [NameInMap("DriverProtocol")]
            [Validation(Required=false)]
            public string DriverProtocol { get; set; }

            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            [NameInMap("CpuArch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("IsBuiltIn")]
            [Validation(Required=false)]
            public bool? IsBuiltIn { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

        }

    }

}
