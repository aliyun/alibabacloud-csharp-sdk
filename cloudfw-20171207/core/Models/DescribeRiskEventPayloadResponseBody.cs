// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventPayloadResponseBody : TeaModel {
        /// <summary>
        /// The destination IP address of the intrusion event.
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// The destination port of the intrusion event.
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        /// <summary>
        /// The destination VPC ID of the intrusion event.
        /// </summary>
        [NameInMap("DstVpcId")]
        [Validation(Required=false)]
        public string DstVpcId { get; set; }

        /// <summary>
        /// The attack payload of the intrusion event.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// The length of the attack payload of the intrusion event.
        /// </summary>
        [NameInMap("PayloadLen")]
        [Validation(Required=false)]
        public int? PayloadLen { get; set; }

        /// <summary>
        /// The protocol type of intrusion event. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// The HTTP X-Real-IP field.
        /// </summary>
        [NameInMap("RealIp")]
        [Validation(Required=false)]
        public string RealIp { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The source IP address of the intrusion event.
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// The source port of the intrusion event.
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// The source VPC ID of the intrusion event.
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// The HTTP X-Forwarded-For field.
        /// </summary>
        [NameInMap("XForwardFor")]
        [Validation(Required=false)]
        public string XForwardFor { get; set; }

    }

}
