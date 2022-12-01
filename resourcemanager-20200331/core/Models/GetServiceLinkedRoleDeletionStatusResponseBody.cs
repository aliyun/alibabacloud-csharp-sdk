// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetServiceLinkedRoleDeletionStatusResponseBody : TeaModel {
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public GetServiceLinkedRoleDeletionStatusResponseBodyReason Reason { get; set; }
        public class GetServiceLinkedRoleDeletionStatusResponseBodyReason : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("RoleUsages")]
            [Validation(Required=false)]
            public GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsages RoleUsages { get; set; }
            public class GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsages : TeaModel {
                [NameInMap("RoleUsage")]
                [Validation(Required=false)]
                public List<GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsage> RoleUsage { get; set; }
                public class GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsage : TeaModel {
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Resources")]
                    [Validation(Required=false)]
                    public GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsageResources Resources { get; set; }
                    public class GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsageResources : TeaModel {
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public List<string> Resource { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
