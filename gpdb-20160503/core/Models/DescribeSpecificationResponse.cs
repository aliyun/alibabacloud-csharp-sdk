// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSpecificationResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceClass")]
        [Validation(Required=true)]
        public List<DescribeSpecificationResponseDBInstanceClass> DBInstanceClass { get; set; }
        public class DescribeSpecificationResponseDBInstanceClass : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=true)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public string Value { get; set; }

        }

        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=true)]
        public List<DescribeSpecificationResponseDBInstanceGroupCount> DBInstanceGroupCount { get; set; }
        public class DescribeSpecificationResponseDBInstanceGroupCount : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=true)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public string Value { get; set; }

        }

        [NameInMap("StorageNotice")]
        [Validation(Required=true)]
        public List<DescribeSpecificationResponseStorageNotice> StorageNotice { get; set; }
        public class DescribeSpecificationResponseStorageNotice : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=true)]
            public string Text { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public string Value { get; set; }

        }

    }

}
