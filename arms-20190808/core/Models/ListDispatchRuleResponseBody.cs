// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDispatchRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("DispatchRules")]
        [Validation(Required=false)]
        public List<ListDispatchRuleResponseBodyDispatchRules> DispatchRules { get; set; }
        public class ListDispatchRuleResponseBodyDispatchRules : TeaModel {
            /// <summary>
            /// <para>The name of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10282</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c></description></item>
            /// <item><description><c>false</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
