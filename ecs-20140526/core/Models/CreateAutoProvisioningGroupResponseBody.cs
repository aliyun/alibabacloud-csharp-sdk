// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the auto provisioning group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-sn54avj8htgvtyh8****</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        /// <summary>
        /// <para>The instances created by the auto provisioning group. The values of the parameters in this array are returned only when AutoProvisioningGroupType is set to <c>instant</c>.</para>
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
                /// <para>The number of created instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The error code returned when the instance cannot be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned when the instance cannot be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Specific parameter is not valid.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The IDs of created instances.</para>
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
                /// <para>The instance type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The bidding policy for the pay-as-you-go instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The instance is a spot instance for which you specify the maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instance is a spot instance for which the market price at the time of purchase is used as the bid price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>745CEC9F-0DD7-4451-9FE7-8B752F39****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
