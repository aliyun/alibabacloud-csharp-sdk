// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemPredefinedRulesRequest : TeaModel {
        /// <summary>
        /// The alert type.
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// The ATT\\&CK information.
        /// </summary>
        [NameInMap("AttCk")]
        [Validation(Required=false)]
        public string AttCk { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// This parameter is required.
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
        /// The method that is used to generate an event. Valid values:
        /// 
        /// *   default: built-in method.
        /// *   singleToSingle: The system generates an event for each alert.
        /// *   allToSingle: The system generates an event for alerts within a period of time.
        /// </summary>
        [NameInMap("EventTransferType")]
        [Validation(Required=false)]
        public string EventTransferType { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The log source.
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// The sort method. Valid values:
        /// 
        /// *   desc: descending order.
        /// *   asc: ascending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The field that is used to sort the rules. Valid values:
        /// 
        /// *   GmtModified: The rules are sorted based on the modification time.
        /// *   Id (default): The rules are sorted based on the rule ID.
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the destination account to which you switch the view from the management account.
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// The type of the view.
        /// 
        /// *   0: view of the current Alibaba Cloud account.
        /// *   1: view of all accounts for the enterprise.
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The name of the rule. The name can contain letters, digits, underscores (_), and periods (.).
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   predefine
        /// *   customize
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
        /// *   0: The rule is in the initial state.
        /// *   10: The simulation data is tested.
        /// *   15: The business data is being tested.
        /// *   20: The business data test ends.
        /// *   100: The rule takes effect.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The risk level. The value is a JSON array. Valid values:
        /// 
        /// *   serious: high
        /// *   suspicious: medium
        /// *   remind: low
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public List<string> ThreatLevel { get; set; }

    }

}
