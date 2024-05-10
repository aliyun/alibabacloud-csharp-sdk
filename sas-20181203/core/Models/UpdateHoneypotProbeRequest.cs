// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// Specifies whether address resolution protocol (ARP) is enabled for the check type.
        /// </summary>
        [NameInMap("Arp")]
        [Validation(Required=false)]
        public bool? Arp { get; set; }

        /// <summary>
        /// The name of the probe.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether ping is enabled for the check type.
        /// </summary>
        [NameInMap("Ping")]
        [Validation(Required=false)]
        public bool? Ping { get; set; }

        /// <summary>
        /// The ID of the probe.
        /// 
        /// > You can call the [ListHoneypotProbe](~~ListHoneypotProbe~~) operation to query the IDs of probes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

        /// <summary>
        /// The IP addresses that are monitored.
        /// </summary>
        [NameInMap("ServiceIpList")]
        [Validation(Required=false)]
        public List<string> ServiceIpList { get; set; }

    }

}
