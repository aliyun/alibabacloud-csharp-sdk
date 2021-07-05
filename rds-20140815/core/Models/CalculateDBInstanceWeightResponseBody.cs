// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CalculateDBInstanceWeightResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public CalculateDBInstanceWeightResponseBodyItems Items { get; set; }
        public class CalculateDBInstanceWeightResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceWeight")]
            [Validation(Required=false)]
            public List<CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight> DBInstanceWeight { get; set; }
            public class CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight : TeaModel {
                public string ReadonlyInstanceSQLDelayedTime { get; set; }
                public string Weight { get; set; }
                public string DBInstanceType { get; set; }
                public string DBInstanceId { get; set; }
                public string Role { get; set; }
            }
        };

    }

}
