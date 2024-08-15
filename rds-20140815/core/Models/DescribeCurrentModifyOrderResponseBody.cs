// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCurrentModifyOrderResponseBody : TeaModel {
        /// <summary>
        /// The specification change order.
        /// </summary>
        [NameInMap("ModifyOrder")]
        [Validation(Required=false)]
        public List<DescribeCurrentModifyOrderResponseBodyModifyOrder> ModifyOrder { get; set; }
        public class DescribeCurrentModifyOrderResponseBodyModifyOrder : TeaModel {
            /// <summary>
            /// The instance family of the instance.
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// The number of CPU cores that are supported by the instance type. Unit: cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// The effective time. Valid values:
            /// 
            /// *   **Immediate**: This is the default value.
            /// *   **MaintainTime**: The effective time is within the maintenance window. For more information, see [ModifyDBInstanceMaintainTime](https://help.aliyun.com/document_detail/610402.html).
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Mark")]
            [Validation(Required=false)]
            public string Mark { get; set; }

            /// <summary>
            /// The memory capacity that is supported by the instance type. Unit: GB.
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// The status of the task.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The storage capacity of the instance.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

            /// <summary>
            /// The new instance type of the instance. Valid values:
            /// </summary>
            [NameInMap("TargetDBInstanceClass")]
            [Validation(Required=false)]
            public string TargetDBInstanceClass { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
