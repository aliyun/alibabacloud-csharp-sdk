// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribePreCheckProgressListResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribePreCheckProgressListResponseBodyItems Items { get; set; }
        public class DescribePreCheckProgressListResponseBodyItems : TeaModel {
            [NameInMap("PreCheckProgressDetail")]
            [Validation(Required=false)]
            public List<DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail> PreCheckProgressDetail { get; set; }
            public class DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail : TeaModel {
                public long? FinishTime { get; set; }
                public string State { get; set; }
                public long? BootTime { get; set; }
                public string JobId { get; set; }
                public string Item { get; set; }
                public string ErrMsg { get; set; }
                public string OrderNum { get; set; }
                public string Names { get; set; }
            }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
