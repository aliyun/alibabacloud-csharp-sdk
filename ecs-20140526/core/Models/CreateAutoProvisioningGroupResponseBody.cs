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
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds InstanceIds { get; set; }
                public class CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
