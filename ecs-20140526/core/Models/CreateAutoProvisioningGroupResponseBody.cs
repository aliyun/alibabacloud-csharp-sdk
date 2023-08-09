// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the auto provisioning group.
        /// </summary>
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        /// <summary>
        /// Details about the instances created by the auto provisioning group. The values of the parameters in this array are returned only when the AutoProvisioningGroupType parameter is set to `instant`.
        /// </summary>
        [NameInMap("LaunchResults")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupResponseBodyLaunchResults LaunchResults { get; set; }
        public class CreateAutoProvisioningGroupResponseBodyLaunchResults : TeaModel {
            [NameInMap("LaunchResult")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResult> LaunchResult { get; set; }
            public class CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResult : TeaModel {
                /// <summary>
                /// The number of instances. Valid values: 1 to 100000.
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The error code returned when the instance cannot be created.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned when the instance cannot be created.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The IDs of created instances.
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds InstanceIds { get; set; }
                public class CreateAutoProvisioningGroupResponseBodyLaunchResultsLaunchResultInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The bidding policy for the pay-as-you-go instance. Valid values:
                /// 
                /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
                /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
