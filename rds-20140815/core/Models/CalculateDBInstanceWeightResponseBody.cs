// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CalculateDBInstanceWeightResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the system-assigned read weight.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public CalculateDBInstanceWeightResponseBodyItems Items { get; set; }
        public class CalculateDBInstanceWeightResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceWeight")]
            [Validation(Required=false)]
            public List<CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight> DBInstanceWeight { get; set; }
            public class CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight : TeaModel {
                /// <summary>
                /// The instance ID
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The type of the instance. Valid values:
                /// 
                /// *   **Master**: primary instance
                /// *   **Readonly**: read-only instance
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The latency at which the read-only instances replicate data. The read-only instances replicate data from the primary instance at the latency that is specified by the **ReadonlyInstanceSQLDelayedTime** parameter. Unit: seconds.
                /// </summary>
                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                /// <summary>
                /// The read weight that the system calculates in real time for the instance.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
