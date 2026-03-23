// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CalculateDBInstanceWeightResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public CalculateDBInstanceWeightResponseBodyItems Items { get; set; }
        public class CalculateDBInstanceWeightResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceWeight")]
            [Validation(Required=false)]
            public List<CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight> DBInstanceWeight { get; set; }
            public class CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
