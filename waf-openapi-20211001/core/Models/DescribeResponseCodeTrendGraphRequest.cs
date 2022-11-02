// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphRequest : TeaModel {
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
