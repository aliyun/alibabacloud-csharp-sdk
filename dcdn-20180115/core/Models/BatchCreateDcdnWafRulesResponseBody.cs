// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchCreateDcdnWafRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDs of created rules.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public BatchCreateDcdnWafRulesResponseBodyRuleIds RuleIds { get; set; }
        public class BatchCreateDcdnWafRulesResponseBodyRuleIds : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public List<string> RuleId { get; set; }

        }

    }

}
