// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetServiceLinkedRoleDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The reason why the deletion task failed.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public GetServiceLinkedRoleDeletionStatusResponseBodyReason Reason { get; set; }
        public class GetServiceLinkedRoleDeletionStatusResponseBodyReason : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service-Linked Role acs:ram::196813227629****:role/aliyunserviceroleforhdr cannot be deleted as it is in use by hdr.aliyuncs.com.</para>
            /// </summary>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07194EB1-DB50-4513-A51D-99B30D635AEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCEEDED: The deletion was successful.</description></item>
        /// <item><description>IN_PROGRESS: The deletion is in progress.</description></item>
        /// <item><description>FAILED: The deletion failed.</description></item>
        /// <item><description>NOT_STARTED: The deletion has not started.</description></item>
        /// <item><description>INTERNAL_ERROR: An internal error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
