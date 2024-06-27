// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAuthRulePageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAuthRulePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAuthRulePageListResponseBodyResultObject : TeaModel {
            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            [NameInMap("createType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public long? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
