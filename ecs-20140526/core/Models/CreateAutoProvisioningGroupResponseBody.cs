// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupResponseBody : TeaModel {
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        [NameInMap("LaunchResults")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupResponseBodyLaunchResults LaunchResults { get; set; }
        public class CreateAutoProvisioningGroupResponseBodyLaunchResults : TeaModel {
            [NameInMap("LaunchResult")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResult> LaunchResult { get; set; }
            public class CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResult : TeaModel {
                public string ErrorCode { get; set; }
                public string ErrorMsg { get; set; }
                public CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds InstanceIds { get; set; }
                public class CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }
                public string InstanceType { get; set; }
                public string SpotStrategy { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
