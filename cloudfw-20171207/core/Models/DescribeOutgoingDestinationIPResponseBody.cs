// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPResponseBody : TeaModel {
        /// <summary>
        /// The IP addresses in outbound connections.
        /// </summary>
        [NameInMap("DstIPList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationIPResponseBodyDstIPList> DstIPList { get; set; }
        public class DescribeOutgoingDestinationIPResponseBodyDstIPList : TeaModel {
            /// <summary>
            /// Indicates whether an access control policy is configured. Valid values:
            /// 
            /// *   **Uncovered**: no
            /// *   **FullCoverage**: yes
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// The suggestion to configure an access control policy.
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// The status of the access control policy. Valid values:
            /// 
            /// *   **normal**: healthy
            /// *   **Abnormal**: unhealthy
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// The information about the address book.
            /// </summary>
            [NameInMap("AddressGroupList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList> AddressGroupList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList : TeaModel {
                /// <summary>
                /// The name of the address book.
                /// </summary>
                [NameInMap("AddressGroupName")]
                [Validation(Required=false)]
                public string AddressGroupName { get; set; }

                /// <summary>
                /// The UUID of the address book.
                /// </summary>
                [NameInMap("AddressGroupUUID")]
                [Validation(Required=false)]
                public string AddressGroupUUID { get; set; }

            }

            /// <summary>
            /// The application ports.
            /// </summary>
            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList : TeaModel {
                /// <summary>
                /// The application type used in the access control policy. Valid values:
                /// 
                /// *   **FTP**
                /// *   **HTTP**
                /// *   **HTTPS**
                /// *   **Memcache**
                /// *   **MongoDB**
                /// *   **MQTT**
                /// *   **MySQL**
                /// *   **RDP**
                /// *   **Redis**
                /// *   **SMTP**
                /// *   **SMTPS**
                /// *   **SSH**
                /// *   **SSL_No_Cert**
                /// *   **SSL**
                /// *   **VNC**
                /// 
                /// >  The value of this parameter depends on the value of the Proto parameter. If you set Proto to TCP, you can set ApplicationNameList to any valid value. If you configure both ApplicationNameList and ApplicationName, only the value of ApplicationNameList is used.
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// The application port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// The type of the tag. Valid values:
            /// 
            /// *   **Suspicious**
            /// *   **Malicious**
            /// *   **Trusted**
            /// </summary>
            [NameInMap("CategoryClassId")]
            [Validation(Required=false)]
            public string CategoryClassId { get; set; }

            /// <summary>
            /// The ID of the service type. Valid values:
            /// 
            /// *   **Aliyun**: Alibaba Cloud services
            /// *   **NotAliyun**: third-party services
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// The type of the service to which the destination IP address belongs. Valid values:
            /// 
            /// *   **Alibaba Cloud services**
            /// *   **Third-party services**
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// The destination IP addresses in outbound connections.
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// The name of the group to which the access control policy belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// Indicates whether an access control policy is configured. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasAcl")]
            [Validation(Required=false)]
            public string HasAcl { get; set; }

            /// <summary>
            /// Indicates whether an access control policy is recommended. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// The inbound traffic. Unit: bytes.
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// Indicates whether the destination IP address is added to a whitelist. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            /// <summary>
            /// The outbound traffic. Unit: bytes.
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// The UUID of the access control policy.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the access control policy.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The reason why the domain name is secure.
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// The suggestion to handle the traffic of the domain name in outbound connections. Valid values:
            /// 
            /// *   **pass**: allow
            /// *   **alert**: deny
            /// *   **drop**: monitor
            /// </summary>
            [NameInMap("SecuritySuggest")]
            [Validation(Required=false)]
            public string SecuritySuggest { get; set; }

            /// <summary>
            /// The number of requests.
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListTagList> TagList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListTagList : TeaModel {
                /// <summary>
                /// The type of the tag. Valid values:
                /// 
                /// *   **Suspicious**
                /// *   **Malicious**
                /// *   **Trusted**
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

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

                /// <summary>
                /// The description of the tag.
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// The ID of the tag.
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// The name of the tag.
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// The total traffic. Unit: bytes
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public string TotalBytes { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of destination IP addresses in outbound connections.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
