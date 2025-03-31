// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListEventCenterRuleNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>031572FA-7D8F-4C05-B790-1071E0E05DE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of names of event notification rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;RuleName\&quot;: \&quot;mlf\&quot;, \&quot;RuleId\&quot;: \&quot;crecr-73q93pgljm1pc2fp\&quot;}]</para>
        /// </summary>
        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public List<ListEventCenterRuleNameResponseBodyRuleNames> RuleNames { get; set; }
        public class ListEventCenterRuleNameResponseBodyRuleNames : TeaModel {
            /// <summary>
            /// <para>The ID of the event notification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crecr-n6pbhgjxtl*****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the event notification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-chain</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
