// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDispatchRuleResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("DispatchRules")]
        [Validation(Required=false)]
        public List<ListDispatchRuleResponseBodyDispatchRules> DispatchRules { get; set; }
        public class ListDispatchRuleResponseBodyDispatchRules : TeaModel {
            /// <summary>
            /// The name of the notification policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the notification policy.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// Indicates whether the notification policy is enabled. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
