// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRulesResponseBody : TeaModel {
        /// <summary>
        /// 异步任务Id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 转发规则标识列表
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<CreateRulesResponseBodyRuleIds> RuleIds { get; set; }
        public class CreateRulesResponseBodyRuleIds : TeaModel {
            /// <summary>
            /// 转发规则标识
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// 转发规则优先级
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

    }

}
