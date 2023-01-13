// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceDriverResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceDriverResponseData Data { get; set; }
        public class QueryEdgeInstanceDriverResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("DriverList")]
            [Validation(Required=true)]
            public List<QueryEdgeInstanceDriverResponseDataDriverList> DriverList { get; set; }
            public class QueryEdgeInstanceDriverResponseDataDriverList : TeaModel {
                [NameInMap("DriverId")]
                [Validation(Required=true)]
                public string DriverId { get; set; }

                [NameInMap("DriverVersion")]
                [Validation(Required=true)]
                public string DriverVersion { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=true)]
                public string GmtModified { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=true)]
                public string OrderId { get; set; }

            }

        }

    }

}
