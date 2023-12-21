// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListExperimentGroupsResponseBody : TeaModel {
        [NameInMap("ExperimentGroups")]
        [Validation(Required=false)]
        public List<ListExperimentGroupsResponseBodyExperimentGroups> ExperimentGroups { get; set; }
        public class ListExperimentGroupsResponseBodyExperimentGroups : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DistributionTimeDuration")]
            [Validation(Required=false)]
            public int? DistributionTimeDuration { get; set; }

            [NameInMap("DistributionType")]
            [Validation(Required=false)]
            public string DistributionType { get; set; }

            [NameInMap("ExperimentGroupId")]
            [Validation(Required=false)]
            public string ExperimentGroupId { get; set; }

            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            [NameInMap("LayerId")]
            [Validation(Required=false)]
            public string LayerId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NeedAA")]
            [Validation(Required=false)]
            public bool? NeedAA { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ReservedBuckets")]
            [Validation(Required=false)]
            public string ReservedBuckets { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
