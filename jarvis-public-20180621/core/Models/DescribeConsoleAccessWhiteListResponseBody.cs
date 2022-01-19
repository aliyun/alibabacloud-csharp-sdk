// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribeConsoleAccessWhiteListResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeConsoleAccessWhiteListResponseBodyDataList> DataList { get; set; }
        public class DescribeConsoleAccessWhiteListResponseBodyDataList : TeaModel {
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtRealExpire")]
            [Validation(Required=false)]
            public string GmtRealExpire { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("InsProduct")]
            [Validation(Required=false)]
            public string InsProduct { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeConsoleAccessWhiteListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeConsoleAccessWhiteListResponseBodyPageInfo : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
