// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaResponseBody : TeaModel {
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
