// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class QueryStorageCommodityListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryStorageCommodityListResponseBodyData> Data { get; set; }
        public class QueryStorageCommodityListResponseBodyData : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            [NameInMap("Lifecycle")]
            [Validation(Required=false)]
            public int? Lifecycle { get; set; }

            [NameInMap("Months")]
            [Validation(Required=false)]
            public int? Months { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public int? RecordType { get; set; }

            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

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
