// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricSetsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return on each page. Maximum value: 100.
        /// 
        /// Default value:
        /// 
        /// *   If this parameter is left empty, the default value is 10.
        /// *   If this parameter is set to a value greater than 100, the default value is 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The ID of diagnostic metric set N.
        /// </summary>
        [NameInMap("MetricSetIds")]
        [Validation(Required=false)]
        public List<string> MetricSetIds { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value returned in the last call to the DescribeDiagnosticMetricSets operation. Leave this parameter empty the first time you call this operation.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the diagnostic metric set. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// 
        /// Default value: user.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
