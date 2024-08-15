// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAlertRulesRequest : TeaModel {
        /// <summary>
        /// The unique IDs of alert rules.
        /// 
        /// *   If you do not specify this parameter, the API operation does not filter alert rules based on their IDs.
        /// *   If you specify this parameter, the API operation returns only the information of the specified alert rules. Other filter conditions also take effect.
        /// 
        /// > When you call the GetAlertRules operation, you can specify other request parameters to obtain the AlertIds parameter from the response. Then, you can specify the AlertIds parameter to query the specified alert rules.
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// The names of alert rules. When you create alert rules of the new version, you cannot specify duplicate names. However, existing alert rules may have duplicate names. Therefore, the **AlertName** parameter does not uniquely identify an alert rule.
        /// 
        /// *   If you do not specify this parameter, the API operation does not filter alert rules based on their names.
        /// *   If you specify this parameter, the API operation returns only the information of the specified alert rules. Other filter conditions also take effect.
        /// </summary>
        [NameInMap("AlertNames")]
        [Validation(Required=false)]
        public string AlertNames { get; set; }

        /// <summary>
        /// The status of the alert rule. Valid values:
        /// 
        /// *   RUNNING
        /// *   STOPPED
        /// *   PAUSED
        /// 
        /// >  The PAUSED state indicates that the alert rule is abnormal and has been suspended. This may be because the specified threshold value is excessively large, or the associated cluster has been deleted.
        /// </summary>
        [NameInMap("AlertStatus")]
        [Validation(Required=false)]
        public string AlertStatus { get; set; }

        /// <summary>
        /// The type of the alert rule. Valid values:
        /// 
        /// *   APPLICATION_MONITORING_ALERT_RULE: alert rule for Application Monitoring
        /// *   BROWSER_MONITORING_ALERT_RULE: alert rule for Browser Monitoring
        /// *   PROMETHEUS_MONITORING_ALERT_RULE: alert rule for Managed Service for Prometheus
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// The ID of the monitored cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// You do not need to configure this parameter.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of alert rules to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetAlertRulesRequestTags> Tags { get; set; }
        public class GetAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
