// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryTmpEffectReportDayDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryTmpEffectReportDayDataResponseBodyModel Model { get; set; }
        public class QueryTmpEffectReportDayDataResponseBodyModel : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryTmpEffectReportDayDataResponseBodyModelRecords> Records { get; set; }
            public class QueryTmpEffectReportDayDataResponseBodyModelRecords : TeaModel {
                [NameInMap("ClickPv")]
                [Validation(Required=false)]
                public string ClickPv { get; set; }

                [NameInMap("ClickUv")]
                [Validation(Required=false)]
                public string ClickUv { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("ExposePv")]
                [Validation(Required=false)]
                public string ExposePv { get; set; }

                [NameInMap("ExposeUv")]
                [Validation(Required=false)]
                public string ExposeUv { get; set; }

                [NameInMap("RptSuccessCount")]
                [Validation(Required=false)]
                public string RptSuccessCount { get; set; }

                [NameInMap("TmpCode")]
                [Validation(Required=false)]
                public string TmpCode { get; set; }

                [NameInMap("TmpName")]
                [Validation(Required=false)]
                public string TmpName { get; set; }

                [NameInMap("VendorName")]
                [Validation(Required=false)]
                public string VendorName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
