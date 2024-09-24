// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenIpResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenIpResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetOpenIpResponseBodyDataList : TeaModel {
            /// <summary>
            /// The reason why recommended intelligent policies are unavailable. Valid values:
            /// 
            /// *   No recommended intelligent policies are available.
            /// *   This feature is available only to some users.
            /// *   The policy configuration has been modified. No recommended intelligent policies are available.
            /// *   The recommended intelligent policies have been configured. No new recommended intelligent policies are available.
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            /// <summary>
            /// The instance name.
            /// </summary>
            [NameInMap("AssetsName")]
            [Validation(Required=false)]
            public string AssetsName { get; set; }

            /// <summary>
            /// The asset type of the instance.
            /// </summary>
            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            /// <summary>
            /// The total number of ports.
            /// </summary>
            [NameInMap("DetailNum")]
            [Validation(Required=false)]
            public int? DetailNum { get; set; }

            /// <summary>
            /// Specifies whether an access control policy is recommended. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// The list of ports.
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<string> PortList { get; set; }

            /// <summary>
            /// The public IP address of the instance.
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **3**: high risk
            /// *   **2**: medium risk
            /// *   **1**: low risk
            /// *   **0**: no risk
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// The reason for the risk.
            /// </summary>
            [NameInMap("RiskReason")]
            [Validation(Required=false)]
            public string RiskReason { get; set; }

            /// <summary>
            /// The list of applications.
            /// </summary>
            [NameInMap("ServiceNameList")]
            [Validation(Required=false)]
            public List<string> ServiceNameList { get; set; }

            [NameInMap("SrcIpCnt")]
            [Validation(Required=false)]
            public long? SrcIpCnt { get; set; }

            [NameInMap("TotalReplyBytes")]
            [Validation(Required=false)]
            public long? TotalReplyBytes { get; set; }

            /// <summary>
            /// The percentage of traffic of a day. Unit: percent (%).
            /// </summary>
            [NameInMap("TrafficPercent1Day")]
            [Validation(Required=false)]
            public string TrafficPercent1Day { get; set; }

            /// <summary>
            /// The percentage of traffic of 30 days. Unit: percent (%).
            /// </summary>
            [NameInMap("TrafficPercent30Day")]
            [Validation(Required=false)]
            public string TrafficPercent30Day { get; set; }

            /// <summary>
            /// The percentage of traffic of seven days. Unit: percent (%).
            /// </summary>
            [NameInMap("TrafficPercent7Day")]
            [Validation(Required=false)]
            public string TrafficPercent7Day { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInternetOpenIpResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInternetOpenIpResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
