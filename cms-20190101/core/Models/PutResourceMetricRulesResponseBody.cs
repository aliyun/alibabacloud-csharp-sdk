// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesResponseBody : TeaModel {
        /// <summary>
        /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
        /// 
        /// Valid values of N: 1 to 500.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("FailedListResult")]
        [Validation(Required=false)]
        public PutResourceMetricRulesResponseBodyFailedListResult FailedListResult { get; set; }
        public class PutResourceMetricRulesResponseBodyFailedListResult : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesResponseBodyFailedListResultTarget> Target { get; set; }
            public class PutResourceMetricRulesResponseBodyFailedListResultTarget : TeaModel {
                /// <summary>
                /// The alert rules that failed to be created for the resource.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public PutResourceMetricRulesResponseBodyFailedListResultTargetResult Result { get; set; }
                public class PutResourceMetricRulesResponseBodyFailedListResultTargetResult : TeaModel {
                    /// <summary>
                    /// For more information about common request parameters, see [Common parameters](~~199331~~).
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                /// <summary>
                /// The statistical period of the metric.
                /// 
                /// Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.
                /// 
                /// Valid values of N: 1 to 500.
                /// 
                /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// Valid values of N: 1 to 500.
        /// 
        /// You can specify a new ID or the ID of an existing alert rule. For information about how to query the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// 
        /// >  If you specify a new ID, you create a threshold-triggered alert rule.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The alert rule that failed to be created.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The key of the tag.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
