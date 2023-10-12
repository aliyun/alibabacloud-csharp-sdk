// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenIpResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenIpResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetOpenIpResponseBodyDataList : TeaModel {
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            [NameInMap("AssetsName")]
            [Validation(Required=false)]
            public string AssetsName { get; set; }

            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            [NameInMap("DetailNum")]
            [Validation(Required=false)]
            public int? DetailNum { get; set; }

            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<string> PortList { get; set; }

            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            [NameInMap("RiskReason")]
            [Validation(Required=false)]
            public string RiskReason { get; set; }

            [NameInMap("ServiceNameList")]
            [Validation(Required=false)]
            public List<string> ServiceNameList { get; set; }

            [NameInMap("TrafficPercent1Day")]
            [Validation(Required=false)]
            public string TrafficPercent1Day { get; set; }

            [NameInMap("TrafficPercent30Day")]
            [Validation(Required=false)]
            public string TrafficPercent30Day { get; set; }

            [NameInMap("TrafficPercent7Day")]
            [Validation(Required=false)]
            public string TrafficPercent7Day { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInternetOpenIpResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInternetOpenIpResponseBodyPageInfo : TeaModel {
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
