// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CalculateDBInstanceWeightResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the system-assigned read weights.
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
                /// The ID of instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The role of the instance. Valid values:
                /// 
                /// *   **Master**: primary instance
                /// *   **Readonly**: read-only instance
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The threshold for the latency of data replication from the primary instance to the read-only instances. The read-only instances start to synchronize data from the primary instance after the time specified by the **ReadonlyInstanceSQLDelayedTime** parameter elapses. Unit: seconds.
                /// </summary>
                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                /// <summary>
                /// The read weight that ApsaraDB RDS calculates in real time for the instance.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
