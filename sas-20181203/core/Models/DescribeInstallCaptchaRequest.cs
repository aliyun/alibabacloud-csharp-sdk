// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaRequest : TeaModel {
        /// <summary>
        /// The validity period of verification codes. If this parameter is not specified, only the valid verification codes are returned.
        /// 
        /// >  An installation verification code can be used only within the validity period. An expired installation verification code cannot be used to install the Security Center agent.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

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
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
