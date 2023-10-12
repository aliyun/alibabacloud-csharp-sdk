// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventPayloadRequest : TeaModel {
        /// <summary>
        /// The destination IP address to query. If you specify this parameter, all intrusion events with the specified destination IP address are queried.
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// The ID of the destination VPC to query. If you specify this parameter, all intrusion events that contain the specified ID of the destination VPC are queried.
        /// </summary>
        [NameInMap("DstVpcId")]
        [Validation(Required=false)]
        public string DstVpcId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the firewall. Valid values:
        /// 
        /// *   **VpcFirewall**: virtual private cloud (VPC) firewall
        /// *   **InternetFirewall** (default): Internet firewall
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// The public IP address. If you specify this parameter, all intrusion events that contain the specified public IP address are queried.
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// The source IP address to query. If you specify this parameter, all intrusion events from the specified source IP address are queried.
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// The ID of the source VPC to query. If you specify this parameter, all intrusion events that contain the specified ID of the source VPC are queried.
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The UUID of the intrusion event.
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
