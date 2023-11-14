// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSwitchStatusRequest : TeaModel {
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
