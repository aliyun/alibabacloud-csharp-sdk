// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverResponse : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeDriverResponseData Data { get; set; }
        public class QueryEdgeDriverResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("DriverList")]
            [Validation(Required=true)]
            public List<QueryEdgeDriverResponseDataDriverList> DriverList { get; set; }
            public class QueryEdgeDriverResponseDataDriverList : TeaModel {
                public string DriverId { get; set; }
                public string DriverName { get; set; }
                public string DriverProtocol { get; set; }
                public string Runtime { get; set; }
                public string CpuArch { get; set; }
                public int? Type { get; set; }
                public bool? IsBuiltIn { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
            }
        };

    }

}
