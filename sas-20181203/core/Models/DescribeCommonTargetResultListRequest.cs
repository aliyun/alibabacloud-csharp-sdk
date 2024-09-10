// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the configuration item. Valid values:
        /// 
        /// *   **webshell_timescan**: webshell detection and removal
        /// *   **aliscriptengine**: in-depth detection engine
        /// *   **alidetect**: installation scope of local file detection
        /// *   **alidetect-scan-enable**: detection scope of local file detection
        /// 
        /// >  You can call the [ListClientUserDefineRules](~~ListClientUserDefineRules~~) and [ListSystemClientRules](~~ListSystemClientRules~~) operations to obtain more types of custom and system configuration items.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
