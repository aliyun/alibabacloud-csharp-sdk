// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSpecificationResponseBody : TeaModel {
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public List<DescribeSpecificationResponseBodyDBInstanceClass> DBInstanceClass { get; set; }
        public class DescribeSpecificationResponseBodyDBInstanceClass : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public List<DescribeSpecificationResponseBodyDBInstanceGroupCount> DBInstanceGroupCount { get; set; }
        public class DescribeSpecificationResponseBodyDBInstanceGroupCount : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageNotice")]
        [Validation(Required=false)]
        public List<DescribeSpecificationResponseBodyStorageNotice> StorageNotice { get; set; }
        public class DescribeSpecificationResponseBodyStorageNotice : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
