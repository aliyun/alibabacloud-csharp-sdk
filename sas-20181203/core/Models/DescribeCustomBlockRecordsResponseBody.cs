// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockRecordsResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCustomBlockRecordsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockRecordsResponseBodyRecordList> RecordList { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyRecordList : TeaModel {
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            [NameInMap("Bound")]
            [Validation(Required=false)]
            public string Bound { get; set; }

            [NameInMap("EnableCount")]
            [Validation(Required=false)]
            public int? EnableCount { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeCustomBlockRecordsResponseBodyRecordListTargetList> TargetList { get; set; }
            public class DescribeCustomBlockRecordsResponseBodyRecordListTargetList : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
