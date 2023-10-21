// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleCountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of alert rules in each state.
        /// </summary>
        [NameInMap("MetricRuleCount")]
        [Validation(Required=false)]
        public DescribeMetricRuleCountResponseBodyMetricRuleCount MetricRuleCount { get; set; }
        public class DescribeMetricRuleCountResponseBodyMetricRuleCount : TeaModel {
            /// <summary>
            /// The number of alert rules with active alerts.
            /// </summary>
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public int? Alarm { get; set; }

            /// <summary>
            /// The number of disabled alert rules.
            /// </summary>
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public int? Disable { get; set; }

            /// <summary>
            /// The number of alert rules without data.
            /// </summary>
            [NameInMap("Nodata")]
            [Validation(Required=false)]
            public int? Nodata { get; set; }

            /// <summary>
            /// The number of alert rules without active alerts.
            /// </summary>
            [NameInMap("Ok")]
            [Validation(Required=false)]
            public int? Ok { get; set; }

            /// <summary>
            /// The total number of alert rules.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
