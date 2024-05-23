// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectStepMetricRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public string Aggregator { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTimestamp")]
        [Validation(Required=false)]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("MaxPointNum")]
        [Validation(Required=false)]
        public int? MaxPointNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}
