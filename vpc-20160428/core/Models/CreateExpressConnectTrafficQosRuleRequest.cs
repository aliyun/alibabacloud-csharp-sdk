// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressConnectTrafficQosRuleRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The destination IPv4 CIDR block that matches the QoS rule traffic.
        /// 
        /// > When this parameter is unavailable, specify **SrcIPv6Cidr** or **DstIPv6Cidr**.
        /// </summary>
        [NameInMap("DstCidr")]
        [Validation(Required=false)]
        public string DstCidr { get; set; }

        /// <summary>
        /// The destination IPv6 CIDR block that matches the QoS rule traffic.
        /// 
        /// > When this parameter is unavailable, specify **SrcCidr** or **DstCidr**.
        /// </summary>
        [NameInMap("DstIPv6Cidr")]
        [Validation(Required=false)]
        public string DstIPv6Cidr { get; set; }

        /// <summary>
        /// The range of destination ports that match the QoS rule traffic. Valid values: **0** to **65535**. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number. Different protocols correspond to different ports. Valid values:
        /// 
        /// *   **ALL** (uneditable): -1/-1.
        /// *   **ICMP(IPv4)** (uneditable): -1/-1.
        /// *   **ICMPv6(IPv6)** (uneditable): -1/-1.
        /// *   **TCP** (editable): -1/-1.
        /// *   **UDP** (editable): -1/-1.
        /// *   **GRE** (uneditable): -1/-1.
        /// *   **SSH** (uneditable): 22/22.
        /// *   **Telnet** (uneditable): 23/23.
        /// *   **HTTP** (uneditable): 80/80.
        /// *   **HTTPS** (uneditable): 443/443.
        /// *   **MS SQL** (uneditable): 1443/1443.
        /// *   **Oracle** (uneditable): 1521/1521.
        /// *   **MySql** (uneditable): 3306/3306.
        /// *   **RDP** (uneditable): 3389/3389.
        /// *   **PostgreSQL** (uneditable): 5432/5432.
        /// *   **Redis** (uneditable): 6379/6379.
        /// </summary>
        [NameInMap("DstPortRange")]
        [Validation(Required=false)]
        public string DstPortRange { get; set; }

        /// <summary>
        /// The DSCP value that matches the QoS rule traffic. Valid values: **0** to **63**. If no value is matched, the value is -1.
        /// </summary>
        [NameInMap("MatchDscp")]
        [Validation(Required=false)]
        public int? MatchDscp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The priority of the QoS rule. Valid values: **1** to **9000**. A larger value indicates a higher priority. The priority of each QoS rule must be unique in the same QoS policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The protocol of the QoS rule. Valid values:
        /// 
        /// *   **ALL**
        /// *   **ICMP(IPv4)**
        /// *   **ICMPv6(IPv6)**
        /// *   **TCP**
        /// *   **UDP**
        /// *   **GRE**
        /// *   **SSH**
        /// *   **Telnet**
        /// *   **HTTP**
        /// *   **HTTPS**
        /// *   **MS SQL**
        /// *   **Oracle**
        /// *   **MySql**
        /// *   **RDP**
        /// *   **PostgreSQL**
        /// *   **Redis**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the QoS policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// The ID of the QoS queue.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// The region ID of the QoS policy.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The new DSCP value. Valid values: **0** to **63**. If you do not change the value, set the value to -1.
        /// </summary>
        [NameInMap("RemarkingDscp")]
        [Validation(Required=false)]
        public int? RemarkingDscp { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The description of the QoS rule.
        /// 
        /// The description must be 0 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// The name of the QoS rule.
        /// 
        /// The name must be 0 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The source IPv4 CIDR block that matches the QoS rule traffic.
        /// 
        /// > When this parameter is unavailable, specify **SrcIPv6Cidr** or **DstIPv6Cidr**.
        /// </summary>
        [NameInMap("SrcCidr")]
        [Validation(Required=false)]
        public string SrcCidr { get; set; }

        /// <summary>
        /// The source IPv6 CIDR block that matches the QoS rule traffic.
        /// 
        /// > When this parameter is unavailable, specify **SrcCidr** or **DstCidr**.
        /// </summary>
        [NameInMap("SrcIPv6Cidr")]
        [Validation(Required=false)]
        public string SrcIPv6Cidr { get; set; }

        /// <summary>
        /// The range of source ports that match the QoS rule traffic. Valid values: **0** to **65535**. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number.
        /// </summary>
        [NameInMap("SrcPortRange")]
        [Validation(Required=false)]
        public string SrcPortRange { get; set; }

    }

}
