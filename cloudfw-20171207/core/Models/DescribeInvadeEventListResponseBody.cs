// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListResponseBody : TeaModel {
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventListResponseBodyEventList> EventList { get; set; }
        public class DescribeInvadeEventListResponseBodyEventList : TeaModel {
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            [NameInMap("AssetsInstanceName")]
            [Validation(Required=false)]
            public string AssetsInstanceName { get; set; }

            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            [NameInMap("EventKey")]
            [Validation(Required=false)]
            public string EventKey { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public int? FirstTime { get; set; }

            [NameInMap("IsIgnore")]
            [Validation(Required=false)]
            public bool? IsIgnore { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public int? LastTime { get; set; }

            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            [NameInMap("PublicIpType")]
            [Validation(Required=false)]
            public string PublicIpType { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        [NameInMap("HighLevelPercent")]
        [Validation(Required=false)]
        public int? HighLevelPercent { get; set; }

        [NameInMap("LowLevelPercent")]
        [Validation(Required=false)]
        public int? LowLevelPercent { get; set; }

        [NameInMap("MiddleLevelPercent")]
        [Validation(Required=false)]
        public int? MiddleLevelPercent { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInvadeEventListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInvadeEventListResponseBodyPageInfo : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
