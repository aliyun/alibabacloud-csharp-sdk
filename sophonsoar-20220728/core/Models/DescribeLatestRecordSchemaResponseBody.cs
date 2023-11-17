// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeLatestRecordSchemaResponseBody : TeaModel {
        [NameInMap("PlaybookNodeSchema")]
        [Validation(Required=false)]
        public DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema PlaybookNodeSchema { get; set; }
        public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema : TeaModel {
            [NameInMap("NodeSchema")]
            [Validation(Required=false)]
            public List<DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema> NodeSchema { get; set; }
            public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema : TeaModel {
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("OutputFields")]
                [Validation(Required=false)]
                public List<string> OutputFields { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
