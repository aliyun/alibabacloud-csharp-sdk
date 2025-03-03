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
            /// <para>Failure information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service-Linked Role acs:ram::196813227629****:role/aliyunserviceroleforhdr cannot be deleted as it is in use by hdr.aliyuncs.com.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Use resource information of the service linked role.</para>
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
                    /// <para>The IDs of the regions in which the resources are to be queried.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>global</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The returned resources.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07194EB1-DB50-4513-A51D-99B30D635AEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
        /// <list type="bullet">
        /// <item><description>SUCCEEDED</description></item>
        /// <item><description>IN_PROGRESS</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>NOT_STARTED</description></item>
        /// <item><description>INTERNAL_ERROR</description></item>
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
