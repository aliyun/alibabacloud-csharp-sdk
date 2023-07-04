// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupRequest : TeaModel {
        /// <summary>
        /// The names of attacked applications. Set the value in the `["AttackApp1","AttackApp2"]` format.
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        /// <summary>
        /// The attack type of the intrusion events. Valid values:
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
        /// 
        /// > If you do not specify this parameter, the intrusion events of all attack types are queried.
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// The edition of Cloud Firewall that you purchase. Valid values:
        /// 
        /// *   **2**: Premium Edition
        /// *   **3**: Enterprise Edition
        /// *   **4**: Ultimate Edition
        /// *   **10**: Cloud Firewall that uses the pay-as-you-go billing method
        /// </summary>
        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public long? BuyVersion { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The type of the risk events.\
        /// Set the value to **session**, which indicates intrusion events.
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// The direction of the traffic for the intrusion events. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// 
        /// > If you do not specify this parameter, the intrusion events that are recorded for both inbound and outbound traffic are queried.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The destination IP address to query. If you specify this parameter, all intrusion events with the specified destination IP address are queried.
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// The ID of the destination VPC.
        /// 
        /// > If the FirewallType parameter is set to VpcFirewall, you must specify this parameter.
        /// </summary>
        [NameInMap("DstNetworkInstanceId")]
        [Validation(Required=false)]
        public string DstNetworkInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 入侵防御事件的名称。
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The type of the firewall. Valid values:
        /// 
        /// *   **VpcFirewall**: virtual private cloud (VPC) firewall
        /// *   **InternetFirewall**: Internet firewall (default)
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to query the information about the geographical locations of IP addresses.
        /// 
        /// *   **true**: does not query the information about the geographical locations of IP addresses.
        /// *   **false**: queries the information about the geographical locations of IP addresses. This is the default value.
        /// </summary>
        [NameInMap("NoLocation")]
        [Validation(Required=false)]
        public string NoLocation { get; set; }

        /// <summary>
        /// The order in which you want to sort the results. Valid values:
        /// 
        /// *   **asc**: the ascending order.
        /// *   **desc**: the descending order. This is the default value.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: **6**. Maximum value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The status of the firewall. Valid values:
        /// 
        /// *   **1**: alerting
        /// *   **2**: blocking
        /// 
        /// > If you do not specify this parameter, all intrusion events that are detected by the firewall are queried, regardless of the firewall status.
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// The module of the rule that is used to detect the intrusion events. Valid values:
        /// 
        /// *   **1**: basic protection
        /// *   **2**: virtual patching
        /// *   **4**: threat intelligence
        /// 
        /// > If you do not specify this parameter, the intrusion events that are detected by all rules are queried.
        /// </summary>
        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        /// <summary>
        /// The field based on which you want to sort the results. Valid values:
        /// 
        /// *   **VulLevel**: The results are sorted based on the risk level field. This is the default value.
        /// *   **LastTime**: The results are sorted based on the most recent occurrence time.
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// The source IP address to query. If you specify this parameter, all intrusion events with the specified source IP address are queried.
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// The ID of the source VPC.
        /// 
        /// > If the FirewallType parameter is set to VpcFirewall, you must specify this parameter.
        /// </summary>
        [NameInMap("SrcNetworkInstanceId")]
        [Validation(Required=false)]
        public string SrcNetworkInstanceId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The risk level of the intrusion events. Valid values:
        /// 
        /// *   **1**: low
        /// *   **2**: medium
        /// *   **3**: high
        /// 
        /// > If you do not specify this parameter, the intrusion events that are at all risk levels are queried.
        /// </summary>
        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

    }

}
