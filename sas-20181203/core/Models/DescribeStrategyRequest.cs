// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyRequest : TeaModel {
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public string StrategyIds { get; set; }

    }

}
