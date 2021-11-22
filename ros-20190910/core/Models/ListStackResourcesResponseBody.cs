// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListStackResourcesResponseBodyResources> Resources { get; set; }
        public class ListStackResourcesResponseBodyResources : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
