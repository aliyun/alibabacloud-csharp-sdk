// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverAvailableZonesRequest : TeaModel {
        [NameInMap("AzId")]
        [Validation(Required=false)]
        public string AzId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ResolverRegionId")]
        [Validation(Required=false)]
        public string ResolverRegionId { get; set; }

    }

}
