// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaResponseBody : TeaModel {
        /// <summary>
        /// Queries the verification code for you to manually install the Security Center agent.
        /// </summary>
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// 192.168.XX.XX
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
