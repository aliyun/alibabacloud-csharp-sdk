// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesResponseBody : TeaModel {
        [NameInMap("DBInstanceClasses")]
        [Validation(Required=false)]
        public List<DescribeAvailableClassesResponseBodyDBInstanceClasses> DBInstanceClasses { get; set; }
        public class DescribeAvailableClassesResponseBodyDBInstanceClasses : TeaModel {
            [NameInMap("DBInstanceStorageRange")]
            [Validation(Required=false)]
            public DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange DBInstanceStorageRange { get; set; }
            public class DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange : TeaModel {
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public int? MaxValue { get; set; }
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public int? MinValue { get; set; }
            };

            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
