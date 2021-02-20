// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeOrgAttackSurfaceDetailsResponseBody : TeaModel {
        [NameInMap("LastScannedAt")]
        [Validation(Required=false)]
        public long? LastScannedAt { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FirstScannedAt")]
        [Validation(Required=false)]
        public long? FirstScannedAt { get; set; }

        [NameInMap("Occurrences")]
        [Validation(Required=false)]
        public int? Occurrences { get; set; }

    }

}
