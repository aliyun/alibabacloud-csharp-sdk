// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteDiagnosticMetricSetsRequest : TeaModel {
        /// <summary>
        /// The ID of diagnostic metric set.
        /// </summary>
        [NameInMap("MetricSetIds")]
        [Validation(Required=false)]
        public List<string> MetricSetIds { get; set; }

        /// <summary>
        /// The IDs of diagnostic metric sets. You can specify up to 10 set IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
