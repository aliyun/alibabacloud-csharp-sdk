// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleStatus")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyRoleStatus RoleStatus { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyRoleStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
