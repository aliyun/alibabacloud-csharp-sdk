// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListPlansResponseBody : TeaModel {
        /// <summary>
        /// The operating system types supported by the plan.
        /// </summary>
        [NameInMap("Plans")]
        [Validation(Required=false)]
        public List<ListPlansResponseBodyPlans> Plans { get; set; }
        public class ListPlansResponseBodyPlans : TeaModel {
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
            /// 
            /// >  CNY is for the China site (aliyun.com). USD is for the international site (alibabacloud.com).
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The size of the disk. Unit: GB.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// The category of the disk. Valid values:
            /// 
            /// *   SSD: standard SSDs
            /// *   ESSD: enhanced SSDs
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
            /// The monthly price of the plan.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
