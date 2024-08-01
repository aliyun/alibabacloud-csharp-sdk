// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticReportRequest : TeaModel {
        /// <summary>
        /// The end of the reporting period. This parameter takes effect only for diagnostic metrics that do not need to be assessed by running Cloud Assistant commands in guest operating systems.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the diagnostic metric set. If this parameter is left empty, the dms-instancedefault set is used, which is the default diagnostic metric set provided for Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// The ID of the region in which to create a diagnostic report. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The beginning of the reporting period. This parameter takes effect only for diagnostic metrics that do not need to be assessed by running Cloud Assistant commands in guest operating systems.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
