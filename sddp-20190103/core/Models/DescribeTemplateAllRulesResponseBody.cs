// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeTemplateAllRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<DescribeTemplateAllRulesResponseBodyRuleList> RuleList { get; set; }
        public class DescribeTemplateAllRulesResponseBodyRuleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>376</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Model Name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
