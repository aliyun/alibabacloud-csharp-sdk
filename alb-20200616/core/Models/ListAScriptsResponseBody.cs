// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAScriptsResponseBody : TeaModel {
        /// <summary>
        /// The AScript rules.
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<ListAScriptsResponseBodyAScripts> AScripts { get; set; }
        public class ListAScriptsResponseBodyAScripts : TeaModel {
            /// <summary>
            /// The AScript rule ID.
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

            /// <summary>
            /// The name of the AScript rule.
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// The status of the AScript rule. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Available**
            /// *   **Configuring**
            /// *   **Deleting**
            /// </summary>
            [NameInMap("AScriptStatus")]
            [Validation(Required=false)]
            public string AScriptStatus { get; set; }

            /// <summary>
            /// Indicates whether the AScript rule is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The Application Load Balancer (ALB) instance ID.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The content of the AScript rule.
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// 
        /// > This parameter is optional. By default, this parameter is not returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
