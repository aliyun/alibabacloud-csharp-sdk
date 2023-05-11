// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleActionsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information about error codes, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// If the call is successful, all configured data forwarding actions of the specified rule are returned. For more information about the returned data, see the following **RuleActionInfo** parameter.
        /// </summary>
        [NameInMap("RuleActionList")]
        [Validation(Required=false)]
        public ListRuleActionsResponseBodyRuleActionList RuleActionList { get; set; }
        public class ListRuleActionsResponseBodyRuleActionList : TeaModel {
            [NameInMap("RuleActionInfo")]
            [Validation(Required=false)]
            public List<ListRuleActionsResponseBodyRuleActionListRuleActionInfo> RuleActionInfo { get; set; }
            public class ListRuleActionsResponseBodyRuleActionListRuleActionInfo : TeaModel {
                /// <summary>
                /// The configurations of the data destination.
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// Indicates whether the data destination is used to receive the error operation data. The error operation data is data that failed to be forwarded two consecutive times.
                /// 
                /// *   **true**: This destination is used to receive error operation data.
                /// *   **false**: This destination is not used to receive error operation data.
                /// </summary>
                [NameInMap("ErrorActionFlag")]
                [Validation(Required=false)]
                public bool? ErrorActionFlag { get; set; }

                /// <summary>
                /// The ID of the action in which data is forwarded to the destination.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the rule based on which data is forwarded to the destination.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// The status of the data forwarding action. Valid values:
                /// 
                /// *   **INIT**: The action is being configured.
                /// *   **NORMAL**: The configuration is complete, and the action can run properly.
                /// *   **INVALID**: The configuration data is invalid, and the action fails to run.
                /// *   **SHORTCUT**: An exception occurs and the data forwarding action is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the action in which data is forwarded to a destination. Valid values:
                /// 
                /// *   **REPUBLISH**: Data is forwarded to a topic.
                /// *   **OTS**: Data is stored in Tablestore.
                /// *   **MNS**: Data is forwarded to Message Service (MNS).
                /// *   **ONS**: Data is forwarded to Message Queue for Apache RocketMQ.
                /// *   **TSDB**: Data is stored in Time Series Database.
                /// *   **FC**: Data is forwarded to Function Compute.
                /// *   **RDS**: Data is forwarded to ApsaraDB RDS.
                /// *   **AMQP**: Data is forwarded to an Advanced Message Queuing Protocol (AMQP) consumer group.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the call was successful. 
        /// 
        /// - **true**: The call was successful.
        /// - **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
