// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackInstance")]
        [Validation(Required=false)]
        public GetStackInstanceResponseBodyStackInstance StackInstance { get; set; }
        public class GetStackInstanceResponseBodyStackInstance : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }
            [NameInMap("ParameterOverrides")]
            [Validation(Required=false)]
            public List<GetStackInstanceResponseBodyStackInstanceParameterOverrides> ParameterOverrides { get; set; }
            public class GetStackInstanceResponseBodyStackInstanceParameterOverrides : TeaModel {
                public string ParameterKey { get; set; }
                public string ParameterValue { get; set; }
            }
            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }
        };

    }

}
