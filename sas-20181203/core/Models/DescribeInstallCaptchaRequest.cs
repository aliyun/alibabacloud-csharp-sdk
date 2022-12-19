// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaRequest : TeaModel {
        /// <summary>
        /// The validity period of the installation verification code. If this parameter is not specified, the validity period is 1 hour.
        /// 
        /// >  The installation verification code is valid only within the validity period. An expired installation verification code cannot be used to install the agent.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

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
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
