// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7GlobalRuleResponseBody : TeaModel {
        [NameInMap("GlobalRules")]
        [Validation(Required=false)]
        public List<DescribeL7GlobalRuleResponseBodyGlobalRules> GlobalRules { get; set; }
        public class DescribeL7GlobalRuleResponseBodyGlobalRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>watch</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>watch</para>
            /// </summary>
            [NameInMap("ActionDefault")]
            [Validation(Required=false)]
            public string ActionDefault { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>global_1</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
