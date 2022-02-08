// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CreateRateRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("CustomerLabels")]
        [Validation(Required=false)]
        public string CustomerLabels { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public string Score { get; set; }

    }

}
