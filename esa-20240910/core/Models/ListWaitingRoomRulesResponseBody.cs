// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to trace a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The waiting room bypass rules.</para>
        /// </summary>
        [NameInMap("WaitingRoomRules")]
        [Validation(Required=false)]
        public List<ListWaitingRoomRulesResponseBodyWaitingRoomRules> WaitingRoomRules { get; set; }
        public class ListWaitingRoomRulesResponseBodyWaitingRoomRules : TeaModel {
            /// <summary>
            /// <para>The rule content, which is a policy or conditional expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(http.request.uri.path.file_name eq \&quot;jpg\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37286782688****</para>
            /// </summary>
            [NameInMap("WaitingRoomRuleId")]
            [Validation(Required=false)]
            public long? WaitingRoomRuleId { get; set; }

        }

    }

}
