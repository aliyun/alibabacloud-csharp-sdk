// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticMetricSetRequest : TeaModel {
        /// <summary>
        /// testDescription
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of diagnostic metric.
        /// </summary>
        [NameInMap("MetricIds")]
        [Validation(Required=false)]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// my_dms
        /// </summary>
        [NameInMap("MetricSetName")]
        [Validation(Required=false)]
        public string MetricSetName { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// Default value: instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the diagnostic metric set.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
