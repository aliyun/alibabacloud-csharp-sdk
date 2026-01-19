// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSIntelligentAclRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfos")]
        [Validation(Required=false)]
        public List<DescribeHttpDDoSIntelligentAclRulesResponseBodyRuleInfos> RuleInfos { get; set; }
        public class DescribeHttpDDoSIntelligentAclRulesResponseBodyRuleInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;$and&quot;:[{&quot;key&quot;:&quot;URI&quot;,&quot;opValue&quot;:&quot;prefix-match&quot;,&quot;values&quot;:&quot;/&quot;}]}</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000030</para>
            /// </summary>
            [NameInMap("LogRuleId")]
            [Validation(Required=false)]
            public long? LogRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("PunishTime")]
            [Validation(Required=false)]
            public long? PunishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20569929</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>smart_cc_***</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
