// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class DescribeOssStsRequest : TeaModel {
        [NameInMap("ak")]
        [Validation(Required=false)]
        public string Ak { get; set; }

        [NameInMap("cloudType")]
        [Validation(Required=false)]
        public string CloudType { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("sk")]
        [Validation(Required=false)]
        public string Sk { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
