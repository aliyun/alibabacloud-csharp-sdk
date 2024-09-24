// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSearchConditionResponseBody : TeaModel {
        [NameInMap("ConditionList")]
        [Validation(Required=false)]
        public List<DescribeSearchConditionResponseBodyConditionList> ConditionList { get; set; }
        public class DescribeSearchConditionResponseBodyConditionList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ConditionType")]
            [Validation(Required=false)]
            public string ConditionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;filterParams\&quot;:[{\&quot;labelKey\&quot;:\&quot;a|b\&quot;,\&quot;value\&quot;:\&quot;{\\\&quot;name\\\&quot;:\\\&quot;sadsasd\\\&quot;,\\\&quot;value\\\&quot;:\\\&quot;dasdsdas\\\&quot;}\&quot;}],\&quot;LogicalExp\&quot;:\&quot;OR\&quot;}</para>
            /// </summary>
            [NameInMap("FilterConditions")]
            [Validation(Required=false)]
            public string FilterConditions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StopMachine</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stop_machine</para>
            /// </summary>
            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3AEC47AF-8CFA-485E-AC9A-3A8ABC06EA7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
