// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyRequest : TeaModel {
        /// <summary>
        /// The type of the baseline check policy. Valid values:
        /// 
        /// *   **custom**: a custom baseline check policy
        /// *   **common**: a standard baseline check policy
        /// </summary>
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// The new interval of the baseline check. Valid values:
        /// 
        /// *   **1**: every 2 days
        /// *   **3**: every 4 days
        /// *   **7**: every 8 days
        /// *   **30**: every 31 days
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public string CycleDays { get; set; }

        /// <summary>
        /// The new time range during which the baseline check starts. Valid values:
        /// 
        /// *   **0**: The baseline check starts within the time range from 00:00 to 06:00.
        /// *   **6**: The baseline check starts within the time range from 06:00 to 12:00.
        /// *   **12**: The baseline check starts within the time range from 12:00 to 18:00.
        /// *   **18**: The baseline check starts within the time range from 18:00 to 24:00.
        /// 
        /// >  This parameter is deprecated.
        /// </summary>
        [NameInMap("CycleStartTime")]
        [Validation(Required=false)]
        public string CycleStartTime { get; set; }

        /// <summary>
        /// The time when the baseline check based on the baseline check policy ends. Specify the time in the hh:mm:ss format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the baseline check policy.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The new name of the baseline check policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The custom configurations of the baseline. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **typeName**: the name of the baseline.
        /// 
        /// *   **checkDetails**: the details of the baseline. The value is in the JSON format.
        /// 
        ///     *   **checkId**: the ID of the check item.
        /// 
        ///     *   **rules**: the rule configurations. The value is in the JSON format.
        /// 
        ///         *   **ruleId**: the ID of the rule.
        /// 
        ///         *   **paramList**: the list of parameters in the rule. The value is in the JSON format.
        /// 
        ///             *   **paramName**: the name of the parameter.
        ///             *   **value**: the value of the parameter.
        /// </summary>
        [NameInMap("RiskCustomParams")]
        [Validation(Required=false)]
        public string RiskCustomParams { get; set; }

        /// <summary>
        /// The subtype of the baselines. You can call the [DescribeRiskType](~~DescribeRiskType~~) operation to query the subtypes of baselines.
        /// </summary>
        [NameInMap("RiskSubTypeName")]
        [Validation(Required=false)]
        public string RiskSubTypeName { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The time when the baseline check based on the baseline check policy starts. Specify the time in the hh:mm:ss format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The method that is used to apply the baseline check policy. Valid values:
        /// 
        /// *   **groupId**: asset groups
        /// *   **uuid**: assets
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
