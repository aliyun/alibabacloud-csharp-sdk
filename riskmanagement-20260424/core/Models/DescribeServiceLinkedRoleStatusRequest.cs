// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeServiceLinkedRoleStatusRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusRequestSdkRequest SdkRequest { get; set; }
        public class DescribeServiceLinkedRoleStatusRequestSdkRequest : TeaModel {
            [NameInMap("ServiceLinkedRole")]
            [Validation(Required=false)]
            public string ServiceLinkedRole { get; set; }

        }

    }

}
