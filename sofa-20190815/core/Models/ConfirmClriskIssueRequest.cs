// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ConfirmClriskIssueRequest : TeaModel {
        [NameInMap("FalseAlarm")]
        [Validation(Required=false)]
        public bool? FalseAlarm { get; set; }

        [NameInMap("FundLoss")]
        [Validation(Required=false)]
        public bool? FundLoss { get; set; }

        [NameInMap("IssueId")]
        [Validation(Required=false)]
        public long? IssueId { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

    }

}
