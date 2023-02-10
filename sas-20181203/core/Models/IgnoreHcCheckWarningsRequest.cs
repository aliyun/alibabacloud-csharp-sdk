// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreHcCheckWarningsRequest : TeaModel {
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        [NameInMap("CheckWarningIds")]
        [Validation(Required=false)]
        public string CheckWarningIds { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public string RiskId { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
