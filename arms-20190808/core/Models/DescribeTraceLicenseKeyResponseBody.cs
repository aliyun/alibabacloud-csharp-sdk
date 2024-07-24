// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeTraceLicenseKeyResponseBody : TeaModel {
        /// <summary>
        /// The license key for the application.
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
