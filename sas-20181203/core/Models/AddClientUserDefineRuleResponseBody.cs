// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddClientUserDefineRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>379a9b8f-107b-4630-9e95-2299a1ea****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The identifier of the custom defense rule.</para>
        /// </summary>
        [NameInMap("UserDefineRuleAddResult")]
        [Validation(Required=false)]
        public AddClientUserDefineRuleResponseBodyUserDefineRuleAddResult UserDefineRuleAddResult { get; set; }
        public class AddClientUserDefineRuleResponseBodyUserDefineRuleAddResult : TeaModel {
            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The type of the operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows</description></item>
            /// <item><description><b>linux</b>: Linux</description></item>
            /// <item><description><b>all</b>: all types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The switch ID of the custom defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-DEFINE-RULE-SWITCH-TYPE_200****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

    }

}
