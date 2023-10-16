// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkMonitorResultsResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTrademarkMonitorResultsResponseBodyData Data { get; set; }
        public class QueryTrademarkMonitorResultsResponseBodyData : TeaModel {
            [NameInMap("TmMonitorResult")]
            [Validation(Required=false)]
            public List<QueryTrademarkMonitorResultsResponseBodyDataTmMonitorResult> TmMonitorResult { get; set; }
            public class QueryTrademarkMonitorResultsResponseBodyDataTmMonitorResult : TeaModel {
                [NameInMap("ApplyDate")]
                [Validation(Required=false)]
                public string ApplyDate { get; set; }

                [NameInMap("ChesanEndDate")]
                [Validation(Required=false)]
                public string ChesanEndDate { get; set; }

                [NameInMap("Classification")]
                [Validation(Required=false)]
                public string Classification { get; set; }

                [NameInMap("DataCreateTime")]
                [Validation(Required=false)]
                public long? DataCreateTime { get; set; }

                [NameInMap("DataUpdateTime")]
                [Validation(Required=false)]
                public long? DataUpdateTime { get; set; }

                [NameInMap("OwnerEnName")]
                [Validation(Required=false)]
                public string OwnerEnName { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                [NameInMap("RegistrationNumber")]
                [Validation(Required=false)]
                public string RegistrationNumber { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("TmImage")]
                [Validation(Required=false)]
                public string TmImage { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

                [NameInMap("TmProcedureStatusDesc")]
                [Validation(Required=false)]
                public string TmProcedureStatusDesc { get; set; }

                [NameInMap("TmUid")]
                [Validation(Required=false)]
                public string TmUid { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("WuxiaoEndDate")]
                [Validation(Required=false)]
                public string WuxiaoEndDate { get; set; }

                [NameInMap("XuzhanEndDate")]
                [Validation(Required=false)]
                public string XuzhanEndDate { get; set; }

                [NameInMap("YiyiEndDate")]
                [Validation(Required=false)]
                public string YiyiEndDate { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
