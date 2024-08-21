// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillResponseBody : TeaModel {
        [NameInMap("AssetStatus")]
        [Validation(Required=false)]
        public int? AssetStatus { get; set; }

        /// <summary>
        /// The payment status. Valid values:
        /// 
        /// *   **0**: The payment is not overdue.
        /// *   **1**: The payment is overdue.
        /// </summary>
        [NameInMap("DebtStatus")]
        [Validation(Required=false)]
        public long? DebtStatus { get; set; }

        /// <summary>
        /// The details about the traffic of EIPs with Anti-DDoS (Enhanced) enabled.
        /// </summary>
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyFlowList> FlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyFlowList : TeaModel {
            /// <summary>
            /// The traffic distribution by region. The JSON struct contains the following fields:
            /// 
            /// *   **bytes**: the traffic volume of EIPs with Anti-DDoS (Enhanced) enabled in a region. Unit: bytes.
            /// *   **memberUid**: the owner account.
            /// *   **instanceId**: the ID of the pay-as-you-go instance that protects the EIPs with Anti-DDoS (Enhanced) enabled.
            /// *   **ip**: the EIPs with Anti-DDoS (Enhanced) enabled.
            /// *   **region**: the region.
            /// 
            /// >  If the memberUid field in the JSON struct is empty, the information about the current account is returned. The value of the bytes parameter in the outermost level of the JSON struct indicates the total traffic, and the values of the bytes parameters in inner levels indicate the traffic of the account.
            /// </summary>
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            /// <summary>
            /// The traffic distribution by region. The JSON struct contains the following fields:
            /// 
            /// *   **bytes**: the traffic volume of EIPs with Anti-DDoS (Enhanced) enabled in a region. Unit: bytes.
            /// *   **instanceId**: the ID of the pay-as-you-go instance that protects the EIPs with Anti-DDoS (Enhanced) enabled.
            /// *   **ip**: the EIPs with Anti-DDoS (Enhanced) enabled.
            /// *   **region**: the region.
            /// </summary>
            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            /// <summary>
            /// The timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// The traffic of EIPs with Anti-DDoS (Enhanced) enabled. Unit: bytes.
            /// </summary>
            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        /// <summary>
        /// The traffic distribution of EIPs with Anti-DDoS (Enhanced) enabled by region.
        /// </summary>
        [NameInMap("FlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlowRegion { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Origin (Pay-as-you-go) instance to query.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of protected IP addresses.
        /// </summary>
        [NameInMap("IpCount")]
        [Validation(Required=false)]
        public long? IpCount { get; set; }

        /// <summary>
        /// The protected IP addresses and enabled features.
        /// </summary>
        [NameInMap("IpCountOrFunctionList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList> IpCountOrFunctionList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList : TeaModel {
            /// <summary>
            /// The application scope of the instance. Valid values:
            /// 
            /// *   **only_mainland_china**: regions in the Chinese mainland
            /// *   **global**: all regions
            /// *   **international_and_hmt**: regions outside the Chinese mainland
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// The number of IP addresses protected by the pay-as-you-go instance in the Chinese mainland.
            /// </summary>
            [NameInMap("IpCntCn")]
            [Validation(Required=false)]
            public long? IpCntCn { get; set; }

            /// <summary>
            /// The number of IP addresses protected by the pay-as-you-go instance outside the Chinese mainland.
            /// </summary>
            [NameInMap("IpCntOv")]
            [Validation(Required=false)]
            public long? IpCntOv { get; set; }

            /// <summary>
            /// The bill distribution by account. The JSON struct contains the following fields:
            /// 
            /// *   **eipCnIpCount**: the number of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland
            /// *   **eipOvIpCount**: the number of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland
            /// *   **memberUid**: the owner account
            /// *   **standardAssetsCnIpCount**: the number of IP addresses of regular Alibaba Cloud services in the Chinese mainland
            /// *   **standardAssetsOvIpCount**: the number of IP addresses of regular Alibaba Cloud services outside the Chinese mainland
            /// 
            /// >  If the memberUid field in the JSON struct is empty, the information about the current account is returned.
            /// </summary>
            [NameInMap("MemberIpCnt")]
            [Validation(Required=false)]
            public string MemberIpCnt { get; set; }

            /// <summary>
            /// The billing time. Unit: milliseconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// The IP address distribution. The JSON struct contains the following fields:
        /// 
        /// *   **eipCnIpCount**: the number of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland
        /// *   **eipOvIpCount**: the number of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland
        /// *   **standardAssetsCnIpCount**: the number of IP addresses of regular Alibaba Cloud services in the Chinese mainland
        /// *   **standardAssetsOvIpCount**: the number of IP addresses of regular Alibaba Cloud services outside the Chinese mainland
        /// </summary>
        [NameInMap("IpInfo")]
        [Validation(Required=false)]
        public string IpInfo { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the traffic of regular Alibaba Cloud services.
        /// </summary>
        [NameInMap("StandardAssetsFlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList> StandardAssetsFlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList : TeaModel {
            /// <summary>
            /// The traffic distribution by region. The JSON struct contains the following fields:
            /// 
            /// *   **bytes**: the traffic volume of regular Alibaba Cloud services in a region. Unit: bytes.
            /// *   **memberUid**: the owner account.
            /// *   **instanceId**: the ID of the pay-as-you-go instance that protects the regular Alibaba Cloud services.
            /// *   **ip**: the IP address of the regular Alibaba Cloud service protected by the Anti-DDoS Origin instance.
            /// *   **region**: the region.
            /// 
            /// >  If the memberUid field in the JSON struct is empty, the information about the current account is returned. The value of the bytes parameter in the outermost level of the JSON struct indicates the total traffic, and the values of the bytes parameters in inner levels indicate the traffic of the account.
            /// </summary>
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            /// <summary>
            /// The traffic distribution by region. The JSON struct contains the following fields:
            /// 
            /// *   **bytes**: the traffic volume of regular Alibaba Cloud services in a region. Unit: bytes.
            /// *   **instanceId**: the ID of the pay-as-you-go instance that protects the regular Alibaba Cloud services.
            /// *   **ip**: the IP address protected by the Anti-DDoS Origin instance.
            /// *   **region**: the region.
            /// </summary>
            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            /// <summary>
            /// The timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// The traffic of regular Alibaba Cloud services. Unit: bytes.
            /// </summary>
            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        /// <summary>
        /// The traffic distribution of regular Alibaba Cloud services by region.
        /// </summary>
        [NameInMap("StandardAssetsFlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> StandardAssetsFlowRegion { get; set; }

        /// <summary>
        /// The total traffic of regular Alibaba Cloud services in the Chinese mainland in the current month.
        /// </summary>
        [NameInMap("StandardAssetsTotalFlowCn")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowCn { get; set; }

        /// <summary>
        /// The total traffic of regular Alibaba Cloud services outside the Chinese mainland in the current month.
        /// </summary>
        [NameInMap("StandardAssetsTotalFlowOv")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowOv { get; set; }

        /// <summary>
        /// The instance status. Valid values:
        /// 
        /// *   **1**: normal
        /// *   **2**: expired
        /// *   **3**: released
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// The total traffic of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland in the current month. Unit: bytes.
        /// </summary>
        [NameInMap("TotalFlowCn")]
        [Validation(Required=false)]
        public long? TotalFlowCn { get; set; }

        /// <summary>
        /// The total traffic of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland in the current month. Unit: bytes.
        /// </summary>
        [NameInMap("TotalFlowOv")]
        [Validation(Required=false)]
        public long? TotalFlowOv { get; set; }

    }

}
