// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotProbeBindRequest : TeaModel {
        /// <summary>
        /// The ports that are bound to the probe.
        /// </summary>
        [NameInMap("BindPortList")]
        [Validation(Required=false)]
        public List<CreateHoneypotProbeBindRequestBindPortList> BindPortList { get; set; }
        public class CreateHoneypotProbeBindRequestBindPortList : TeaModel {
            /// <summary>
            /// Specifies whether to bind the port. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("BindPort")]
            [Validation(Required=false)]
            public bool? BindPort { get; set; }

            /// <summary>
            /// The end port on which the probe monitors.
            /// </summary>
            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public int? EndPort { get; set; }

            /// <summary>
            /// Specifies whether the port is a fixed port. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public bool? Fixed { get; set; }

            /// <summary>
            /// The type of the protocol. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// The start port on which the probe monitors.
            /// </summary>
            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public int? StartPort { get; set; }

            /// <summary>
            /// The destination port.
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

        }

        /// <summary>
        /// The honeypot ID.
        /// 
        /// >  You can call the [ListHoneypot](~~ListHoneypot~~) operation to query the IDs of honeypots.
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The probe ID.
        /// 
        /// >  You can call the [ListHoneypotProbe](~~ListHoneypotProbe~~) operation to query the IDs of probes.
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
