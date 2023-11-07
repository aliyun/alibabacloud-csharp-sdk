// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeUuidRequest : TeaModel {
        /// <summary>
        /// The ID of the management node.
        /// 
        /// >  You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the probe. Valid values:
        /// 
        /// *   **host_probe**: host probe
        /// *   **vpc_black_hole_probe**: virtual private cloud (VPC) probe
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

    }

}
