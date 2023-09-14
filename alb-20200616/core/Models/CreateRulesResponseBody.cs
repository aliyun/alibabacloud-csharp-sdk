// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRulesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the asynchronous task.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The priority of the forwarding rule. Valid values: **1 to 10000**. A lower value specifies a higher priority.
        /// 
        /// > The priorities of the forwarding rules created for the same listener is unique.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<CreateRulesResponseBodyRuleIds> RuleIds { get; set; }
        public class CreateRulesResponseBodyRuleIds : TeaModel {
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
