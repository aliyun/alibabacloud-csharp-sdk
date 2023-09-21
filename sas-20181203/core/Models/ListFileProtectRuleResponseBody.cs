// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectRuleResponseBody : TeaModel {
        [NameInMap("FileProtectList")]
        [Validation(Required=false)]
        public List<ListFileProtectRuleResponseBodyFileProtectList> FileProtectList { get; set; }
        public class ListFileProtectRuleResponseBodyFileProtectList : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            [NameInMap("EffectInstanceCount")]
            [Validation(Required=false)]
            public long? EffectInstanceCount { get; set; }

            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectRuleResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
