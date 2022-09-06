// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeDriverResponseBodyData Data { get; set; }
        public class QueryEdgeDriverResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("DriverList")]
            [Validation(Required=false)]
            public List<QueryEdgeDriverResponseBodyDataDriverList> DriverList { get; set; }
            public class QueryEdgeDriverResponseBodyDataDriverList : TeaModel {
                [NameInMap("CpuArch")]
                [Validation(Required=false)]
                public string CpuArch { get; set; }

                [NameInMap("DriverId")]
                [Validation(Required=false)]
                public string DriverId { get; set; }

                [NameInMap("DriverName")]
                [Validation(Required=false)]
                public string DriverName { get; set; }

                [NameInMap("DriverProtocol")]
                [Validation(Required=false)]
                public string DriverProtocol { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("IsApply")]
                [Validation(Required=false)]
                public bool? IsApply { get; set; }

                [NameInMap("IsBuiltIn")]
                [Validation(Required=false)]
                public bool? IsBuiltIn { get; set; }

                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
