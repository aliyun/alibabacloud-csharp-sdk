// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricSetsResponseBody : TeaModel {
        /// <summary>
        /// A collection of diagnostic metrics.
        /// </summary>
        [NameInMap("MetricSets")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricSetsResponseBodyMetricSets> MetricSets { get; set; }
        public class DescribeDiagnosticMetricSetsResponseBodyMetricSets : TeaModel {
            /// <summary>
            /// The description of the diagnostic metric set.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The IDs of the diagnostic metrics.
            /// </summary>
            [NameInMap("MetricIds")]
            [Validation(Required=false)]
            public List<string> MetricIds { get; set; }

            /// <summary>
            /// The ID of the diagnostic metric set.
            /// </summary>
            [NameInMap("MetricSetId")]
            [Validation(Required=false)]
            public string MetricSetId { get; set; }

            /// <summary>
            /// The name of the diagnostic metric set.
            /// </summary>
            [NameInMap("MetricSetName")]
            [Validation(Required=false)]
            public string MetricSetName { get; set; }

            /// <summary>
            /// The resource type supported by the diagnostic metric set.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The type of the diagnostic metric set. Valid values:
            /// 
            /// *   User: user-defined diagnostic metric set
            /// *   Common: common diagnostic metric set
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
