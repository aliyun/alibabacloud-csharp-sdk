// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyData Data { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeServiceLinkedRoleStatusResponseBodyDataBody Body { get; set; }
            public class DescribeServiceLinkedRoleStatusResponseBodyDataBody : TeaModel {
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("RoleStatus")]
                [Validation(Required=false)]
                public DescribeServiceLinkedRoleStatusResponseBodyDataBodyRoleStatus RoleStatus { get; set; }
                public class DescribeServiceLinkedRoleStatusResponseBodyDataBodyRoleStatus : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
