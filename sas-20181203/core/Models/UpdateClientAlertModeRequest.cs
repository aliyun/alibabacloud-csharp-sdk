// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateClientAlertModeRequest : TeaModel {
        /// <summary>
        /// The protection mode. Valid values:
        /// 
        /// *   **strict**: The strict mode. False positives may be generated. We recommend that you enable this mode during major events.
        /// *   **balance**: The balanced mode. More risks can be detected with less false positives in this mode.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
