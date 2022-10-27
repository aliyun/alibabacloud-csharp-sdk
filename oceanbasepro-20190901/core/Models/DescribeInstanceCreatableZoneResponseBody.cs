// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceCreatableZoneResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeInstanceCreatableZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeInstanceCreatableZoneResponseBodyZoneList : TeaModel {
            [NameInMap("IsInCluster")]
            [Validation(Required=false)]
            public bool? IsInCluster { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
