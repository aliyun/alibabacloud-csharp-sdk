// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// The validity period of the installation verification code. If this parameter is not specified, the validity period is 1 hour.
        /// 
        /// >  The installation verification code is valid only within the validity period. An expired installation verification code cannot be used to install the agent.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// zh
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
