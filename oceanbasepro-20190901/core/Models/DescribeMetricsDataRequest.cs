// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeMetricsDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupByLabels")]
        [Validation(Required=false)]
        public string GroupByLabels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        [NameInMap("ReplicaType")]
        [Validation(Required=false)]
        public string ReplicaType { get; set; }

        [NameInMap("SortMetricKey")]
        [Validation(Required=false)]
        public string SortMetricKey { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
