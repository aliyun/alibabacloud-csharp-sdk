// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleActionResponseBody : TeaModel {
        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the rule action forwarded error operation data that failed to be forwarded to the destination cloud service. A data forwarding failure indicates that forwarding retries also failed.
        /// 
        /// *   **true**: forwards error operation data.
        /// *   **false**: forwards normal data instead of error operation data.
        /// </summary>
        [NameInMap("RuleActionInfo")]
        [Validation(Required=false)]
        public GetRuleActionResponseBodyRuleActionInfo RuleActionInfo { get; set; }
        public class GetRuleActionResponseBodyRuleActionInfo : TeaModel {
            /// <summary>
            /// The ID of rule action.
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// The type of the rule action. Valid values:
            /// 
            /// *   **REPUBLISH**: forwards data to another topic.
            /// *   **OTS**: stores data to Tablestore.
            /// *   **MNS**: sends data to Message Service (MNS).
            /// *   **FC**: sends data to Function Compute.
            /// *   **RDS**: Save to cloud databases.
            /// *   **AMQP**: forwards data to an AMQP consumer group.
            /// </summary>
            [NameInMap("ErrorActionFlag")]
            [Validation(Required=false)]
            public bool? ErrorActionFlag { get; set; }

            /// <summary>
            /// The ID of the rule based on which the rule action is performed.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The configurations of the rule action.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The rule action information returned if the call was successful. For more information, see the following parameters.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
