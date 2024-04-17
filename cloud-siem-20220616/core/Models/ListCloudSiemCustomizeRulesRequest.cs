// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemCustomizeRulesRequest : TeaModel {
        /// <summary>
        /// The alert type.
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the custom rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// The number of entries per page. The value can be up to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   **cn-hangzhou**: Your assets reside in regions in China.
        /// *   **ap-southeast-1**: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The name of the rule. The name can contain letters, digits, underscores (\_), and periods (.).
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   **predefine**
        /// *   **customize**
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The status of the rule. Valid values:
        /// 
        /// *   **0**: The rule is in the initial state.
        /// *   **10**: The simulation data is tested.
        /// *   **15**: The business data is being tested.
        /// *   **20**: The business data test is complete.
        /// *   **100**: The rule is in effect.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The threat level. The value must be a JSON array. Valid values:
        /// 
        /// *   **serious**: high-risk.
        /// *   **suspicious**: medium-risk.
        /// *   **remind**: low-risk.
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public List<string> ThreatLevel { get; set; }

    }

}
