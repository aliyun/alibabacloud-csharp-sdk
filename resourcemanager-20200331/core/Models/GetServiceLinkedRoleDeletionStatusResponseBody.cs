// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetServiceLinkedRoleDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// The reason why the deletion task failed.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public GetServiceLinkedRoleDeletionStatusResponseBodyReason Reason { get; set; }
        public class GetServiceLinkedRoleDeletionStatusResponseBodyReason : TeaModel {
            /// <summary>
            /// Failure information.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Use resource information of the service linked role.
            /// </summary>
            [NameInMap("RoleUsages")]
            [Validation(Required=false)]
            public GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsages RoleUsages { get; set; }
            public class GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsages : TeaModel {
                [NameInMap("RoleUsage")]
                [Validation(Required=false)]
                public List<GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsage> RoleUsage { get; set; }
                public class GetServiceLinkedRoleDeletionStatusResponseBodyReasonRoleUsagesRoleUsage : TeaModel {
                    /// <summary>
                    /// The IDs of the regions in which the resources are to be queried.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The returned resources.
                    /// </summary>
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the task.
        /// 
        /// - SUCCEEDED
        /// - IN_PROGRESS
        /// - FAILED
        /// - NOT_STARTED
        /// - INTERNAL_ERROR
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
