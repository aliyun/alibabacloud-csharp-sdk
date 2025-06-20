// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryRegionAzResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRegionAzResponseBodyData Data { get; set; }
        public class QueryRegionAzResponseBodyData : TeaModel {
            [NameInMap("DataInfo")]
            [Validation(Required=false)]
            public List<QueryRegionAzResponseBodyDataDataInfo> DataInfo { get; set; }
            public class QueryRegionAzResponseBodyDataDataInfo : TeaModel {
                [NameInMap("AzList")]
                [Validation(Required=false)]
                public List<string> AzList { get; set; }

                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public QueryRegionAzResponseBodyDataPagination Pagination { get; set; }
            public class QueryRegionAzResponseBodyDataPagination : TeaModel {
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
