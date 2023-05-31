// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAppVulScanCycleRequest : TeaModel {
        /// <summary>
        /// The scan cycle for application vulnerabilities.
        /// 
        /// *   1week
        /// *   2weeks
        /// *   3days
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

    }

}
