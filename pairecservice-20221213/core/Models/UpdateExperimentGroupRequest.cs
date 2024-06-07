// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateExperimentGroupRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        [NameInMap("CrowdTargetType")]
        [Validation(Required=false)]
        public string CrowdTargetType { get; set; }

        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        [NameInMap("DebugUsers")]
        [Validation(Required=false)]
        public string DebugUsers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DistributionTimeDuration")]
        [Validation(Required=false)]
        public int? DistributionTimeDuration { get; set; }

        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LayerId")]
        [Validation(Required=false)]
        public string LayerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NeedAA")]
        [Validation(Required=false)]
        public bool? NeedAA { get; set; }

        [NameInMap("RandomFlow")]
        [Validation(Required=false)]
        public long? RandomFlow { get; set; }

        [NameInMap("ReservcedBuckets")]
        [Validation(Required=false)]
        public string ReservcedBuckets { get; set; }

    }

}
