// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricsRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The ID of diagnostic metric.
        /// </summary>
        [NameInMap("MetricIds")]
        [Validation(Required=false)]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Maximum value: 100.
        /// 
        /// Default value:
        /// 
        /// *   If this parameter is left empty, the default value is 10.
        /// *   If this parameter is set to a value greater than 100, the default value is 100.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The IDs of diagnostic metrics.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value returned in the last call to the DescribeDiagnosticMetrics operation. Leave this parameter empty the first time you call this operation.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
