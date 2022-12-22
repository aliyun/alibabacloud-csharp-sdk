// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of breach awareness events.
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventListResponseBodyEventList> EventList { get; set; }
        public class DescribeInvadeEventListResponseBodyEventList : TeaModel {
            /// <summary>
            /// The ID of the affected asset.
            /// </summary>
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            /// <summary>
            /// The name of the affected asset.
            /// </summary>
            [NameInMap("AssetsInstanceName")]
            [Validation(Required=false)]
            public string AssetsInstanceName { get; set; }

            /// <summary>
            /// The type of the affected asset. Valid values:
            /// 
            /// * **BastionHostIP**: the egress IP address of a bastion host
            /// * **BastionHostIngressIP**: the ingress IP address of a bastion host
            /// * **EcsEIP**: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance
            /// * **EcsPublicIP**: the public IP address of an ECS instance
            /// * **EIP**: the EIP
            /// * **EniEIP**: the EIP of an elastic network interface (ENI)
            /// * **NatEIP**: the EIP of a NAT gateway
            /// * **SlbEIP**: the EIP of a Server Load Balancer (SLB) instance
            /// * **SlbPublicIP**: the public IP address of an SLB instance
            /// * **NatPublicIP**: the public IP address of a NAT gateway
            /// * **HAVIP**: the high-availability virtual IP address (HAVIP)
            /// </summary>
            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            /// <summary>
            /// The ID of the breach awareness event.
            /// </summary>
            [NameInMap("EventKey")]
            [Validation(Required=false)]
            public string EventKey { get; set; }

            /// <summary>
            /// The name of the breach awareness event.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The type of the breach awareness event. Valid values:
            /// 
            /// *   **IPS**: intrusion prevention event
            /// *   **offline**: disconnection event
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// The UUID of the breach awareness event.
            /// </summary>
            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            /// <summary>
            /// The time when the breach awareness event first occurred. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public int? FirstTime { get; set; }

            /// <summary>
            /// Indicates whether the breach awareness event is ignored. Valid values:
            /// 
            /// *   **true**: The breach awareness event is ignored.
            /// *   **false**: The breach awareness event is not ignored.
            /// </summary>
            [NameInMap("IsIgnore")]
            [Validation(Required=false)]
            public bool? IsIgnore { get; set; }

            /// <summary>
            /// The time when the breach awareness event last occurred. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public int? LastTime { get; set; }

            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// The private IP address of the affected asset.
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// The handling status of the breach awareness event. Valid values:
            /// 
            /// *   **0**: unhandled
            /// *   **20**: handled
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// The public IP address of the affected asset.
            /// </summary>
            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            /// <summary>
            /// The type of the affected asset. Valid values:
            /// 
            /// * **BastionHostIP**: the egress IP address of a bastion host
            /// * **BastionHostIngressIP**: the ingress IP address of a bastion host
            /// * **EcsEIP**: the EIP of an ECS instance
            /// * **EcsPublicIP**: the public IP address of an ECS instance
            /// * **EIP**: the EIP
            /// * **EniEIP**: the EIP of an ENI
            /// * **NatEIP**: the EIP of a NAT gateway
            /// * **SlbEIP**: the EIP of an SLB instance
            /// * **SlbPublicIP**: the public IP address of an SLB instance
            /// * **NatPublicIP**: the public IP address of a NAT gateway
            /// * **HAVIP**: the HAVIP
            /// </summary>
            [NameInMap("PublicIpType")]
            [Validation(Required=false)]
            public string PublicIpType { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **1**: low
            /// *   **2**: medium
            /// *   **3**: high
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// The ratio of high-risk events.
        /// </summary>
        [NameInMap("HighLevelPercent")]
        [Validation(Required=false)]
        public int? HighLevelPercent { get; set; }

        /// <summary>
        /// The ratio of low-risk events.
        /// </summary>
        [NameInMap("LowLevelPercent")]
        [Validation(Required=false)]
        public int? LowLevelPercent { get; set; }

        /// <summary>
        /// The ratio of medium-risk events.
        /// </summary>
        [NameInMap("MiddleLevelPercent")]
        [Validation(Required=false)]
        public int? MiddleLevelPercent { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInvadeEventListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInvadeEventListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of breach awareness events.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
