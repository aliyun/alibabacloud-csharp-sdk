// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DeepCopyRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeepCopyRuleResponseBodyResultObject ResultObject { get; set; }
        public class DeepCopyRuleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Whether to redirect to details</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BatchCopyFlag")]
            [Validation(Required=false)]
            public bool? BatchCopyFlag { get; set; }

            /// <summary>
            /// <para>Primary key of the policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>2346</para>
            /// </summary>
            [NameInMap("ConsoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            /// <summary>
            /// <para>Policy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>104556</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>Primary key of the policy version</para>
            /// 
            /// <b>Example:</b>
            /// <para>1135</para>
            /// </summary>
            [NameInMap("RuleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

        }

    }

}
