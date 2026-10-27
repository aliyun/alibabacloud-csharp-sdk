// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class BatchModifyEntitlementResponseBody : TeaModel {
        /// <summary>
        /// <para>The entitlements collection.</para>
        /// </summary>
        [NameInMap("Entitlements")]
        [Validation(Required=false)]
        public BatchModifyEntitlementResponseBodyEntitlements Entitlements { get; set; }
        public class BatchModifyEntitlementResponseBodyEntitlements : TeaModel {
            /// <summary>
            /// <para>The collection of assignment results.</para>
            /// </summary>
            [NameInMap("AssignModels")]
            [Validation(Required=false)]
            public List<BatchModifyEntitlementResponseBodyEntitlementsAssignModels> AssignModels { get; set; }
            public class BatchModifyEntitlementResponseBodyEntitlementsAssignModels : TeaModel {
                /// <summary>
                /// <para>The cloud desktop ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-e94kzikmpljjx99pl</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The IDs of the users authorized to use the cloud desktop, which are the usernames.</para>
                /// </summary>
                [NameInMap("EndUserIds")]
                [Validation(Required=false)]
                public List<string> EndUserIds { get; set; }

                /// <summary>
                /// <para>The assignment result for a single cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("InnerStatus")]
                [Validation(Required=false)]
                public string InnerStatus { get; set; }

            }

            /// <summary>
            /// <para>The overall assignment result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B2F4F018-0EDF-159C-B285-117B5F1C****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51592A88-0F2C-55E6-AD2C-2AD9C10D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
