// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyTargetRequest : TeaModel {
        /// <summary>
        /// The ID of the baseline check policy. The ID is returned after the policy is created. The value of this parameter is in the JSON format and contains the following field:
        /// 
        /// *   **strategyId**: the ID of the policy
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The information about the asset group to which the policy is applied. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **TargetType**: the type of the asset to which the policy is applied. Set the value to **groupId**, which indicates that the policy is applied to an asset group.
        /// 
        /// *   **BindUuidCount**: the number of servers to which the policy is applied.
        /// 
        /// *   **Target**: the ID of the asset group.
        /// 
        /// *   **Flag**: the operation that you want to perform on the asset group. Valid values:
        /// 
        ///     *   **del**: removes the asset group from the policy.
        ///     *   **add**: adds the asset group to the policy.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The configuration type. Set the value to **hc_strategy**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
