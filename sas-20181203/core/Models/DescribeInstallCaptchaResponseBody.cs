// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaResponseBody : TeaModel {
        /// <summary>
        /// The installation verification code for you to manually install the Security Center agent.
        /// </summary>
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// The validity period of the installation verification code.
        /// 
        /// >  The installation verification code is valid only within the validity period. An expired installation verification code cannot be used to install the agent.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
