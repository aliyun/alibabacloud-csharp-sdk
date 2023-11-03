// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClientAlertModeRequest : TeaModel {
        /// <summary>
        /// The protection mode. Valid values:
        /// 
        /// *   **strict**: The strict mode. False positives may be generated. We recommend that you enable this mode during major events.
        /// *   **balance**: The balanced mode. More risks can be detected with less false positives in this mode.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
