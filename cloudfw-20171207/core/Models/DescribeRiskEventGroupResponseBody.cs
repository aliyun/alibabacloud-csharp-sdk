// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the intrusion events.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeRiskEventGroupResponseBodyDataList> DataList { get; set; }
        public class DescribeRiskEventGroupResponseBodyDataList : TeaModel {
            /// <summary>
            /// The name of the attacked application.
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// The attack type of the intrusion event. Valid values:
            /// 
            /// *   **1**: suspicious connection
            /// *   **2**: command execution
            /// *   **3**: brute-force attack
            /// *   **4**: scanning
            /// *   **5**: others
            /// *   **6**: information leak
            /// *   **7**: DoS attack
            /// *   **8**: buffer overflow attack
            /// *   **9**: web attack
            /// *   **10**: trojan backdoor
            /// *   **11**: computer worm
            /// *   **12**: mining
            /// *   **13**: reverse shell
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// The description of the intrusion event.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The direction of the traffic for the intrusion events. Valid values:
            /// 
            /// *   **in**: inbound
            /// *   **out**: outbound
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The destination IP address that is included in the intrusion event.
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// The number of intrusion events.
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// The ID of the intrusion event.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// The name of the intrusion event.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The time when the intrusion event was first detected. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("FirstEventTime")]
            [Validation(Required=false)]
            public int? FirstEventTime { get; set; }

            /// <summary>
            /// The information about the geographical location of the IP address. The value is a struct that contains the following parameters: **CityId**, **CityName**, **CountryId**, and **CountryName**.\
            /// ****************
            /// </summary>
            [NameInMap("IPLocationInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListIPLocationInfo IPLocationInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListIPLocationInfo : TeaModel {
                /// <summary>
                /// The ID of the city to which the IP address belongs.
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }

                /// <summary>
                /// The name of the city to which the IP address belongs.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// The ID of the country to which the IP address belongs.
                /// </summary>
                [NameInMap("CountryId")]
                [Validation(Required=false)]
                public string CountryId { get; set; }

                /// <summary>
                /// The name of the country to which the IP address belongs.
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

            }

            /// <summary>
            /// The time when the intrusion event was last detected. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public int? LastEventTime { get; set; }

            /// <summary>
            /// The information about the private IP address of the intrusion event. The value is an array that contains the following parameters: **RegionNo**, **ResourceInstanceId**, **ResourceInstanceName**, and **ResourcePrivateIP**.\
            /// ****************
            /// </summary>
            [NameInMap("ResourcePrivateIPList")]
            [Validation(Required=false)]
            public List<DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList> ResourcePrivateIPList { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList : TeaModel {
                /// <summary>
                /// The ID of the region to which the private IP address belongs.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// The ID of the instance that uses the private IP address.
                /// </summary>
                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                /// <summary>
                /// The name of the instance that uses the private IP address.
                /// </summary>
                [NameInMap("ResourceInstanceName")]
                [Validation(Required=false)]
                public string ResourceInstanceName { get; set; }

                /// <summary>
                /// The private IP address.
                /// </summary>
                [NameInMap("ResourcePrivateIP")]
                [Validation(Required=false)]
                public string ResourcePrivateIP { get; set; }

            }

            /// <summary>
            /// The type of the public IP address in the intrusion event. Valid values:
            /// 
            /// *   **EIP**: the elastic IP address (EIP)
            /// *   **EcsPublicIP**: the public IP address of an Elastic Compute Service (ECS) instance
            /// *   **EcsEIP**: the EIP of an ECS instance
            /// *   **NatPublicIP**: the public IP address of a NAT gateway
            /// *   **NatEIP**: the EIP of a NAT gateway
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the rule that is used to detect the intrusion event.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The status of the firewall. Valid values:
            /// 
            /// *   **1**: alerting
            /// *   **2**: blocking
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// The module of the rule that is used to detect the intrusion event. Valid values:
            /// 
            /// *   **1**: basic protection
            /// *   **2**: virtual patching
            /// *   **4**: threat intelligence
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public int? RuleSource { get; set; }

            /// <summary>
            /// The source IP address that is included in the intrusion event.
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// The tag added to the source IP address. The tag helps identify whether the source IP address is a back-to-origin IP address for a cloud service.
            /// </summary>
            [NameInMap("SrcIPTag")]
            [Validation(Required=false)]
            public string SrcIPTag { get; set; }

            /// <summary>
            /// The source private IP addresses of the intrusion event.
            /// </summary>
            [NameInMap("SrcPrivateIPList")]
            [Validation(Required=false)]
            public List<string> SrcPrivateIPList { get; set; }

            /// <summary>
            /// The tag added to the threat intelligence that is provided for major events.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The information about the destination VPC of the intrusion event. The value is a struct that contains the following parameters: **EcsInstanceId**, **EcsInstanceName**, **NetworkInstanceId**, **NetworkInstanceName**, and **RegionNo**.\
            /// ********************
            /// </summary>
            [NameInMap("VpcDstInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcDstInfo VpcDstInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcDstInfo : TeaModel {
                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// The name of the ECS instance.
                /// </summary>
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// The ID of the region in which the destination VPC resides.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// The information about the source VPC of the intrusion event. The value is a struct that contains the following parameters: **EcsInstanceId**, **EcsInstanceName**, **NetworkInstanceId**, **NetworkInstanceName**, and **RegionNo**.\
            /// ********************
            /// </summary>
            [NameInMap("VpcSrcInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo VpcSrcInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo : TeaModel {
                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// The name of the ECS instance.
                /// </summary>
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// The ID of the region in which the source VPC resides.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// The risk level of the intrusion event. Valid values:
            /// 
            /// *   **1**: low
            /// *   **2**: medium
            /// *   **3**: high
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public int? VulLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of intrusion events.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
