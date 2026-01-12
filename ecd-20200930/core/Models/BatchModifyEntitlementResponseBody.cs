// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class BatchModifyEntitlementResponseBody : TeaModel {
        /// <summary>
        /// <para>The results.</para>
        /// </summary>
        [NameInMap("Entitlements")]
        [Validation(Required=false)]
        public BatchModifyEntitlementResponseBodyEntitlements Entitlements { get; set; }
        public class BatchModifyEntitlementResponseBodyEntitlements : TeaModel {
            /// <summary>
            /// <para>The assignment results.</para>
            /// </summary>
            [NameInMap("AssignModels")]
            [Validation(Required=false)]
            public List<BatchModifyEntitlementResponseBodyEntitlementsAssignModels> AssignModels { get; set; }
            public class BatchModifyEntitlementResponseBodyEntitlementsAssignModels : TeaModel {
                /// <summary>
                /// <para>The cloud computer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-e94kzikmpljjx99pl</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The authorized user IDs for the cloud computer.</para>
                /// </summary>
                [NameInMap("EndUserIds")]
                [Validation(Required=false)]
                public List<string> EndUserIds { get; set; }

                /// <summary>
                /// <para>The assign result for each cloud computer.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FAILED</description></item>
                /// <item><description>NOT_STARTED</description></item>
                /// <item><description>STARTED</description></item>
                /// <item><description>PROCESSING</description></item>
                /// <item><description>FINISHED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("InnerStatus")]
                [Validation(Required=false)]
                public string InnerStatus { get; set; }

            }

            /// <summary>
            /// <para>The result.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FAILED</description></item>
            /// <item><description>NOT_STARTED</description></item>
            /// <item><description>STARTED</description></item>
            /// <item><description>PROCESSING</description></item>
            /// <item><description>FINISHED</description></item>
            /// </list>
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
