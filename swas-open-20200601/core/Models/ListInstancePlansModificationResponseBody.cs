// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancePlansModificationResponseBody : TeaModel {
        /// <summary>
        /// Details about the plans.
        /// </summary>
        [NameInMap("Plans")]
        [Validation(Required=false)]
        public List<ListInstancePlansModificationResponseBodyPlans> Plans { get; set; }
        public class ListInstancePlansModificationResponseBodyPlans : TeaModel {
            /// <summary>
            /// The peak bandwidth. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// The unit of the plan price. Valid values:
            /// 
            /// *   CNY
            /// *   USD
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The disk size of the simple application server. Unit: GB.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// The category of the disk. Valid values:
            /// 
            /// *   SSD: standard SSD
            /// *   ESSD: enhanced SSD
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The monthly data transfer quota. Unit: GB.
            /// </summary>
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public int? Flow { get; set; }

            /// <summary>
            /// The memory size. Unit: GB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The price of the plan.
            /// </summary>
            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public double? OriginPrice { get; set; }

            /// <summary>
            /// The ID of the plan.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// The operating system types supported by the plan.
            /// </summary>
            [NameInMap("SupportPlatform")]
            [Validation(Required=false)]
            public string SupportPlatform { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
