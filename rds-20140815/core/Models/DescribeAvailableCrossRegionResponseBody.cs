// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableCrossRegionResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of destination regions for cross-region backups.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeAvailableCrossRegionResponseBodyRegions Regions { get; set; }
        public class DescribeAvailableCrossRegionResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<string> Region { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
