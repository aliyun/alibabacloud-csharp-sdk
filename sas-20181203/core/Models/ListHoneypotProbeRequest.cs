// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the probe.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

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
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the probe. Valid values:
        /// 
        /// *   **installed**: installed
        /// *   **install_failed**: installation failed
        /// *   **online**: online
        /// *   **offline**: offline
        /// *   **unnormal**: abnormal
        /// *   **unprobe**: unauthorized
        /// *   **uninstalling**: being uninstalled
        /// *   **uninstalled**: uninstalled
        /// *   **uninstall_failed**: uninstallation failed
        /// *   **not_exist**: not installed
        /// </summary>
        [NameInMap("ProbeStatus")]
        [Validation(Required=false)]
        public string ProbeStatus { get; set; }

        /// <summary>
        /// The type of the probe. Valid values:
        /// 
        /// *   **host_probe**: host probe
        /// *   **vpc_black_hole_probe**: VPC probe
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

    }

}
