// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetRulesCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalSystemClientRuleCount")]
        [Validation(Required=false)]
        public long? TotalSystemClientRuleCount { get; set; }

        [NameInMap("TotalUserDefineRuleCount")]
        [Validation(Required=false)]
        public long? TotalUserDefineRuleCount { get; set; }

    }

}
