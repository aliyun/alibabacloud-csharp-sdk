// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeServiceConsumeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("consumeRecords")]
        [Validation(Required=false)]
        public List<DescribeServiceConsumeResponseBodyConsumeRecords> ConsumeRecords { get; set; }
        public class DescribeServiceConsumeResponseBodyConsumeRecords : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<DescribeServiceConsumeResponseBodyConsumeRecordsRecords> Records { get; set; }
            public class DescribeServiceConsumeResponseBodyConsumeRecordsRecords : TeaModel {
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("serviceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

            }

        }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
