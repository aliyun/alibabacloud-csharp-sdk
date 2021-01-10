// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskRuleTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RuleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TaskRecordList")]
        [Validation(Required=false)]
        public List<ListClriskRuleTasksResponseBodyTaskRecordList> TaskRecordList { get; set; }
        public class ListClriskRuleTasksResponseBodyTaskRecordList : TeaModel {
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public string Cycle { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("PkgCode")]
            [Validation(Required=false)]
            public string PkgCode { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("ResultDetail")]
            [Validation(Required=false)]
            public string ResultDetail { get; set; }

            [NameInMap("ResultSize")]
            [Validation(Required=false)]
            public long? ResultSize { get; set; }

            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
