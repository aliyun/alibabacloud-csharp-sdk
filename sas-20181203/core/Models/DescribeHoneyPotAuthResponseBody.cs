// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotAuthResponseBody : TeaModel {
        /// <summary>
        /// The total quota.
        /// </summary>
        [NameInMap("HoneyPotAuthCount")]
        [Validation(Required=false)]
        public long? HoneyPotAuthCount { get; set; }

        /// <summary>
        /// The quota that is consumed.
        /// </summary>
        [NameInMap("HoneyPotCount")]
        [Validation(Required=false)]
        public int? HoneyPotCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
