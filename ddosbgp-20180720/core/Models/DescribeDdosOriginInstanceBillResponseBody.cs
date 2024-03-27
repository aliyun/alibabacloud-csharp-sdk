// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillResponseBody : TeaModel {
        [NameInMap("DebtStatus")]
        [Validation(Required=false)]
        public long? DebtStatus { get; set; }

        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyFlowList> FlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyFlowList : TeaModel {
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        [NameInMap("FlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlowRegion { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IpCount")]
        [Validation(Required=false)]
        public long? IpCount { get; set; }

        [NameInMap("IpCountOrFunctionList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList> IpCountOrFunctionList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList : TeaModel {
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            [NameInMap("IpCntCn")]
            [Validation(Required=false)]
            public long? IpCntCn { get; set; }

            [NameInMap("IpCntOv")]
            [Validation(Required=false)]
            public long? IpCntOv { get; set; }

            [NameInMap("MemberIpCnt")]
            [Validation(Required=false)]
            public string MemberIpCnt { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        [NameInMap("IpInfo")]
        [Validation(Required=false)]
        public string IpInfo { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StandardAssetsFlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList> StandardAssetsFlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList : TeaModel {
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        [NameInMap("StandardAssetsFlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> StandardAssetsFlowRegion { get; set; }

        [NameInMap("StandardAssetsTotalFlowCn")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowCn { get; set; }

        [NameInMap("StandardAssetsTotalFlowOv")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowOv { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("TotalFlowCn")]
        [Validation(Required=false)]
        public long? TotalFlowCn { get; set; }

        [NameInMap("TotalFlowOv")]
        [Validation(Required=false)]
        public long? TotalFlowOv { get; set; }

    }

}
