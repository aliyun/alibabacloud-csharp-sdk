// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, used for tracking the call status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of waiting room bypass rules.</para>
        /// </summary>
        [NameInMap("WaitingRoomRules")]
        [Validation(Required=false)]
        public List<ListWaitingRoomRulesResponseBodyWaitingRoomRules> WaitingRoomRules { get; set; }
        public class ListWaitingRoomRulesResponseBodyWaitingRoomRules : TeaModel {
            /// <summary>
            /// <para>Rule content, using conditional expressions to match user requests. This parameter does not need to be set when adding global configuration. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: set the value to true</description></item>
            /// <item><description>Match specific requests: set the value to a custom expression, e.g., (http.host eq \&quot;video.example.com\&quot;)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.request.uri.path.file_name eq \&quot;jpg\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch. This parameter does not need to be set when adding global configuration. Value range:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>Rule name. This parameter does not need to be set when adding global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
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
