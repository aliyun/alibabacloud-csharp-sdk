// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The authorization rules that are returned.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyRules> Rules { get; set; }
        public class ListRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The remarks of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the authorization rule. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709258400</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public long? EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the authorization rule. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1685499134</para>
            /// </summary>
            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public long? EffectiveStartTime { get; set; }

            /// <summary>
            /// <para>The authorization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The state of the authorization rule.</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b></description></item>
            /// <item><description><b>Disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("RuleState")]
            [Validation(Required=false)]
            public string RuleState { get; set; }

        }

        /// <summary>
        /// <para>The total number of authorization rules that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
