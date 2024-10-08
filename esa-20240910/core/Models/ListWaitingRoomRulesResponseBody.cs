// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WaitingRoomRules")]
        [Validation(Required=false)]
        public List<ListWaitingRoomRulesResponseBodyWaitingRoomRules> WaitingRoomRules { get; set; }
        public class ListWaitingRoomRulesResponseBodyWaitingRoomRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>(http.request.uri.path.file_name eq \&quot;jpg\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37286782688****</para>
            /// </summary>
            [NameInMap("WaitingRoomRuleId")]
            [Validation(Required=false)]
            public long? WaitingRoomRuleId { get; set; }

        }

    }

}
