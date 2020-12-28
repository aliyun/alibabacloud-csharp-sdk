// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDeploymentSetsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public List<DescribeDeploymentSetsResponseBodyDeploymentSets> DeploymentSets { get; set; }
        public class DescribeDeploymentSetsResponseBodyDeploymentSets : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            [NameInMap("DeploymentStrategy")]
            [Validation(Required=false)]
            public string DeploymentStrategy { get; set; }

            [NameInMap("DeploymentSetDescription")]
            [Validation(Required=false)]
            public string DeploymentSetDescription { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            [NameInMap("DeploymentSetName")]
            [Validation(Required=false)]
            public string DeploymentSetName { get; set; }

            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
