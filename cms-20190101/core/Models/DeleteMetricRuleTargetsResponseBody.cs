// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the message resource that failed to be deleted.
        /// </summary>
        [NameInMap("FailIds")]
        [Validation(Required=false)]
        public DeleteMetricRuleTargetsResponseBodyFailIds FailIds { get; set; }
        public class DeleteMetricRuleTargetsResponseBodyFailIds : TeaModel {
            /// <summary>
            /// Deletes the message resources of an alert rule. This operation supports only Message Service (MNS) resources.
            /// </summary>
            [NameInMap("TargetIds")]
            [Validation(Required=false)]
            public DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds TargetIds { get; set; }
            public class DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds : TeaModel {
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public List<string> TargetId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The message resources that failed to be deleted.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
