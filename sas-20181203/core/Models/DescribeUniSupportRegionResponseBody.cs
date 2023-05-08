// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniSupportRegionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the region that is supported by anti-ransomware for databases.
        /// </summary>
        [NameInMap("UniSupportRegion")]
        [Validation(Required=false)]
        public List<string> UniSupportRegion { get; set; }

    }

}
