// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskIssueResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("IssueList")]
        [Validation(Required=false)]
        public List<ListClriskIssueResponseBodyIssueList> IssueList { get; set; }
        public class ListClriskIssueResponseBodyIssueList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DiffSize")]
            [Validation(Required=false)]
            public long? DiffSize { get; set; }

            [NameInMap("IssueCode")]
            [Validation(Required=false)]
            public string IssueCode { get; set; }

            [NameInMap("IssueId")]
            [Validation(Required=false)]
            public long? IssueId { get; set; }

            [NameInMap("ModelCode")]
            [Validation(Required=false)]
            public string ModelCode { get; set; }

            [NameInMap("ProcessDuration")]
            [Validation(Required=false)]
            public string ProcessDuration { get; set; }

            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TriggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

    }

}
