// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeConfigRuleRequest : TeaModel {
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public long? MemberId { get; set; }

        [NameInMap("MultiAccount")]
        [Validation(Required=false)]
        public bool? MultiAccount { get; set; }

    }

}
