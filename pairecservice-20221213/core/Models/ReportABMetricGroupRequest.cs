// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ReportABMetricGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaseExperimentId")]
        [Validation(Required=false)]
        public string BaseExperimentId { get; set; }

        [NameInMap("DimensionFields")]
        [Validation(Required=false)]
        public string DimensionFields { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExperimentIds")]
        [Validation(Required=false)]
        public string ExperimentIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TimeStatisticsMethod")]
        [Validation(Required=false)]
        public string TimeStatisticsMethod { get; set; }

    }

}
