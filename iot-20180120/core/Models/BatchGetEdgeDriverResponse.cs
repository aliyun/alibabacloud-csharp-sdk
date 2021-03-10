// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeDriverResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("DriverList")]
        [Validation(Required=true)]
        public List<BatchGetEdgeDriverResponseDriverList> DriverList { get; set; }
        public class BatchGetEdgeDriverResponseDriverList : TeaModel {
            [NameInMap("DriverId")]
            [Validation(Required=true)]
            public string DriverId { get; set; }

            [NameInMap("DriverName")]
            [Validation(Required=true)]
            public string DriverName { get; set; }

            [NameInMap("DriverProtocol")]
            [Validation(Required=true)]
            public string DriverProtocol { get; set; }

            [NameInMap("Runtime")]
            [Validation(Required=true)]
            public string Runtime { get; set; }

            [NameInMap("CpuArch")]
            [Validation(Required=true)]
            public string CpuArch { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public int? Type { get; set; }

            [NameInMap("IsBuiltIn")]
            [Validation(Required=true)]
            public bool? IsBuiltIn { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=true)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=true)]
            public long? GmtModifiedTimestamp { get; set; }

        }

    }

}
