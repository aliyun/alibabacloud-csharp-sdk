// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryWaybillOrderStatisticsInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryWaybillOrderStatisticsInfoResponseBodyData> Data { get; set; }
        public class QueryWaybillOrderStatisticsInfoResponseBodyData : TeaModel {
            [NameInMap("AliyunpriceAmount")]
            [Validation(Required=false)]
            public double? AliyunpriceAmount { get; set; }

            [NameInMap("CancelCount")]
            [Validation(Required=false)]
            public int? CancelCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GotCount")]
            [Validation(Required=false)]
            public int? GotCount { get; set; }

            [NameInMap("OrderTotal")]
            [Validation(Required=false)]
            public int? OrderTotal { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

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
