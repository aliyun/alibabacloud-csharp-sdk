// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserSlsLogRegionsResponseBody : TeaModel {
        /// <summary>
        /// The region IDs.
        /// </summary>
        [NameInMap("LogRegions")]
        [Validation(Required=false)]
        public List<string> LogRegions { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
