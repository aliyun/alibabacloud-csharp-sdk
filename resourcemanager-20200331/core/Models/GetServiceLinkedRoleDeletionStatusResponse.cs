// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetServiceLinkedRoleDeletionStatusResponse : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=true)]
        public GetServiceLinkedRoleDeletionStatusResponseReason Reason { get; set; }
        public class GetServiceLinkedRoleDeletionStatusResponseReason : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
            [NameInMap("RoleUsages")]
            [Validation(Required=true)]
            public GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsages RoleUsages { get; set; }
            public class GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsages : TeaModel {
                [NameInMap("RoleUsage")]
                [Validation(Required=true)]
                public List<GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsagesRoleUsage> RoleUsage { get; set; }
                public class GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsagesRoleUsage : TeaModel {
                    [NameInMap("Region")]
                    [Validation(Required=true)]
                    public string Region { get; set; }

                    [NameInMap("Resources")]
                    [Validation(Required=true)]
                    public GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsagesRoleUsageResources Resources { get; set; }
                    public class GetServiceLinkedRoleDeletionStatusResponseReasonRoleUsagesRoleUsageResources : TeaModel {
                        [NameInMap("Resource")]
                        [Validation(Required=true)]
                        public List<string> Resource { get; set; }
                    };

                }

            }
        };

    }

}
