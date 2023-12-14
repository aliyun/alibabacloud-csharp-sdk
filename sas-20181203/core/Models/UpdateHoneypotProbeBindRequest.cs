// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotProbeBindRequest : TeaModel {
        /// <summary>
        /// The unique ID of the honeypot to which the probe is bound.
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public string BindId { get; set; }

        /// <summary>
        /// The ports that are bound to the probe.
        /// </summary>
        [NameInMap("BindPortList")]
        [Validation(Required=false)]
        public List<UpdateHoneypotProbeBindRequestBindPortList> BindPortList { get; set; }
        public class UpdateHoneypotProbeBindRequestBindPortList : TeaModel {
            /// <summary>
            /// Specifies whether to bind a port. Valid values:
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
            /// Specifies whether the port is fixed. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public bool? Fixed { get; set; }

            /// <summary>
            /// The UUID of the port.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
        /// The operation that the probe performs. Valid values:
        /// 
        /// *   **forward_honey**: forward traffic to a honeypot
        /// *   **scan_port**: monitor and scan
        /// </summary>
        [NameInMap("BindType")]
        [Validation(Required=false)]
        public string BindType { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The honeypot ID.
        /// 
        /// >  You can call the [ListHoneypot](~~ListHoneypot~~) operation to obtain the IDs of honeypots.
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// The port ID of the probe service.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ports that are monitored.
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public string Ports { get; set; }

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

        /// <summary>
        /// The status of the port.
        /// </summary>
        [NameInMap("SetStatus")]
        [Validation(Required=false)]
        public int? SetStatus { get; set; }

    }

}
