// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSIntelligentRateLimitRulesResponseBody : TeaModel {
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
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfos")]
        [Validation(Required=false)]
        public List<DescribeHttpDDoSIntelligentRateLimitRulesResponseBodyRuleInfos> RuleInfos { get; set; }
        public class DescribeHttpDDoSIntelligentRateLimitRulesResponseBodyRuleInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>js</para>
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
            /// <para>100030</para>
            /// </summary>
            [NameInMap("LogRuleId")]
            [Validation(Required=false)]
            public long? LogRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("PunishTime")]
            [Validation(Required=false)]
            public long? PunishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;threshold&quot;:2000,&quot;interval&quot;:5,&quot;target&quot;:&quot;ip&quot;,&quot;ttl&quot;:600}</para>
            /// </summary>
            [NameInMap("RateLimit")]
            [Validation(Required=false)]
            public string RateLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20110849</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inner_cc_client_ip_ratelimit</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;field&quot;:&quot;ip&quot;,&quot;mode&quot;:&quot;count&quot;}</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

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
