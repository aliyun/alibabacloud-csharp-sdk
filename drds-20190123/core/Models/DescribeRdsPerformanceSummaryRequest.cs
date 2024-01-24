// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsPerformanceSummaryRequest : TeaModel {
        /// <summary>
        /// The ID of a DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RdsInstanceId")]
        [Validation(Required=false)]
        public List<string> RdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the streaming domain resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
