// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccesskeyLeakListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GmtLast")]
        [Validation(Required=false)]
        public long? GmtLast { get; set; }

        [NameInMap("AkLeakCount")]
        [Validation(Required=false)]
        public int? AkLeakCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AccessKeyLeakList")]
        [Validation(Required=false)]
        public List<DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList> AccessKeyLeakList { get; set; }
        public class DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList : TeaModel {
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            [NameInMap("AccesskeyId")]
            [Validation(Required=false)]
            public string AccesskeyId { get; set; }

            [NameInMap("AliUserName")]
            [Validation(Required=false)]
            public string AliUserName { get; set; }

            [NameInMap("DealType")]
            [Validation(Required=false)]
            public string DealType { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Asset")]
            [Validation(Required=false)]
            public string Asset { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
