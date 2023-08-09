// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticMetricSetResponseBody : TeaModel {
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// The ID of the diagnostic metric set, which is the unique identifier of the set.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
