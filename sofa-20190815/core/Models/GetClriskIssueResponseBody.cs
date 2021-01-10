// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskIssueResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CloseTime")]
        [Validation(Required=false)]
        public string CloseTime { get; set; }

        [NameInMap("CurrentUserOwner")]
        [Validation(Required=false)]
        public bool? CurrentUserOwner { get; set; }

        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        [NameInMap("FalseAlarm")]
        [Validation(Required=false)]
        public bool? FalseAlarm { get; set; }

        [NameInMap("FundLoss")]
        [Validation(Required=false)]
        public bool? FundLoss { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("IssueCode")]
        [Validation(Required=false)]
        public string IssueCode { get; set; }

        [NameInMap("IssueId")]
        [Validation(Required=false)]
        public long? IssueId { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("Processor")]
        [Validation(Required=false)]
        public string Processor { get; set; }

        [NameInMap("ProcessDuration")]
        [Validation(Required=false)]
        public string ProcessDuration { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("RuleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
