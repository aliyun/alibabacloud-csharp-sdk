// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemPredefinedRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCloudSiemPredefinedRulesResponseBodyData Data { get; set; }
        public class ListCloudSiemPredefinedRulesResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCloudSiemPredefinedRulesResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCloudSiemPredefinedRulesResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListCloudSiemPredefinedRulesResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCloudSiemPredefinedRulesResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("RuleDescMds")]
                [Validation(Required=false)]
                public string RuleDescMds { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleNameMds")]
                [Validation(Required=false)]
                public string RuleNameMds { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("ThreatLevel")]
                [Validation(Required=false)]
                public string ThreatLevel { get; set; }

            }

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
