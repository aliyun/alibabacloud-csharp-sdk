// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeVulListPageResponseBodyData> Data { get; set; }
        public class DescribeVulListPageResponseBodyData : TeaModel {
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            [NameInMap("ExtAegis")]
            [Validation(Required=false)]
            public string ExtAegis { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsAegis")]
            [Validation(Required=false)]
            public int? IsAegis { get; set; }

            [NameInMap("IsSas")]
            [Validation(Required=false)]
            public int? IsSas { get; set; }

            [NameInMap("OtherId")]
            [Validation(Required=false)]
            public string OtherId { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
