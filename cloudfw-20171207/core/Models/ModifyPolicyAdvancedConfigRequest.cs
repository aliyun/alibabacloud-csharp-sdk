// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyPolicyAdvancedConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the strict mode for the access control policy. Valid values:
        /// 
        /// *   **on**: enables the strict mode.
        /// *   **off**: disables the strict mode.
        /// </summary>
        [NameInMap("InternetSwitch")]
        [Validation(Required=false)]
        public string InternetSwitch { get; set; }

        /// <summary>
        /// The natural language of the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
