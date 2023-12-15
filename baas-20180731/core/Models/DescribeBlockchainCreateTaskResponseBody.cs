// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeBlockchainCreateTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeBlockchainCreateTaskResponseBodyResult Result { get; set; }
        public class DescribeBlockchainCreateTaskResponseBodyResult : TeaModel {
            [NameInMap("BlockchainCreateTasks")]
            [Validation(Required=false)]
            public List<DescribeBlockchainCreateTaskResponseBodyResultBlockchainCreateTasks> BlockchainCreateTasks { get; set; }
            public class DescribeBlockchainCreateTaskResponseBodyResultBlockchainCreateTasks : TeaModel {
                [NameInMap("Bizid")]
                [Validation(Required=false)]
                public string Bizid { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeBlockchainCreateTaskResponseBodyResultPagination Pagination { get; set; }
            public class DescribeBlockchainCreateTaskResponseBodyResultPagination : TeaModel {
                [NameInMap("Current")]
                [Validation(Required=false)]
                public int? Current { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

    }

}
