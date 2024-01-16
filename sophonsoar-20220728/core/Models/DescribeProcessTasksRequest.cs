// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksRequest : TeaModel {
        /// <summary>
        /// The sort order. Valid values:
        /// 
        /// *   **desc** (default)
        /// *   **asc**
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The name of the handling entity.
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// The type of the handling entity. Valid values:
        /// 
        /// *   **ip**
        /// *   **file**
        /// *   **process**
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The field that you use to sort the result.
        /// 
        /// >  You can obtain the field from the response result.
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// The page number. Default value: 1. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. If you do not specify the PageSize parameter, 10 entries are returned by default.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The handling entity, handling scenario, or handling parameter that is used for fuzzy match.
        /// </summary>
        [NameInMap("ParamContent")]
        [Validation(Required=false)]
        public string ParamContent { get; set; }

        /// <summary>
        /// The end of the time range for a handling task. The value is a 13-digit timestamp.
        /// </summary>
        [NameInMap("ProcessActionEnd")]
        [Validation(Required=false)]
        public long? ProcessActionEnd { get; set; }

        /// <summary>
        /// The beginning of the time range for a handling task. The value is a 13-digit timestamp.
        /// </summary>
        [NameInMap("ProcessActionStart")]
        [Validation(Required=false)]
        public long? ProcessActionStart { get; set; }

        /// <summary>
        /// The end of the time range for an unblocking task. The value is a 13-digit timestamp.
        /// </summary>
        [NameInMap("ProcessRemoveEnd")]
        [Validation(Required=false)]
        public long? ProcessRemoveEnd { get; set; }

        /// <summary>
        /// The beginning of the time range for an unblocking task. The value is a 13-digit timestamp.
        /// </summary>
        [NameInMap("ProcessRemoveStart")]
        [Validation(Required=false)]
        public long? ProcessRemoveStart { get; set; }

        /// <summary>
        /// The UUID of the handling policy.
        /// 
        /// >  You can call the [ListDisposeStrategy](~~2584440~~) operation to query the UUID of the handling policy.
        /// </summary>
        [NameInMap("ProcessStrategyUuid")]
        [Validation(Required=false)]
        public string ProcessStrategyUuid { get; set; }

        /// <summary>
        /// The scenario code of the handling task.
        /// 
        /// >  You can call the [DescribeEnumItems](~~DescribeEnumItems~~) operation to query the scenario code of the handling task. This parameter is available when you set **EnumType** to **process**.
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account that is specified in the handling task.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The triggering source of the handling task. The value is a string array. Valid values:
        /// 
        /// *   **system**: triggered when you manually handle an event
        /// *   **custom**: triggered by an event based on an automatic response rule
        /// *   **custom_alert**: triggered by an alert based on an automatic response rule
        /// *   **soar-manual**: triggered when you use SOAR to manually run a playbook
        /// *   **soar-mdr**: triggered by Managed Security Service
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The unique identifier of the handling task.
        /// 
        /// >  This parameter is used to query a specific task. You can obtain the value from the response result.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The status of the handling task. The value is a string. Valid values:
        /// 
        /// *   **11**: being handled
        /// *   **21**: being blocked
        /// *   **22**: being quarantined
        /// *   **23**: completed
        /// *   **24**: added to the whitelist
        /// *   **20**: successful
        /// *   **90**: failed
        /// *   **91**: unblocking failed
        /// *   **92**: restoring quarantined files failed
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The cloud service that is associated with the handling task. The value is a string. Valid values:
        /// 
        /// *   **WAF**: Web Application Firewall (WAF)
        /// *   **CFW**: Cloud Firewall
        /// *   **Aegis**: Security Center
        /// </summary>
        [NameInMap("YunCode")]
        [Validation(Required=false)]
        public string YunCode { get; set; }

    }

}
