// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSwitchLogResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("LogItems")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceSwitchLogResponseBodyLogItems> LogItems { get; set; }
        public class DescribeDBInstanceSwitchLogResponseBodyLogItems : TeaModel {
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("SwitchCode")]
            [Validation(Required=false)]
            public string SwitchCode { get; set; }

            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
