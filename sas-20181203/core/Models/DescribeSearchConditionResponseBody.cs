// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSearchConditionResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the filter conditions.</para>
        /// </summary>
        [NameInMap("ConditionList")]
        [Validation(Required=false)]
        public List<DescribeSearchConditionResponseBodyConditionList> ConditionList { get; set; }
        public class DescribeSearchConditionResponseBodyConditionList : TeaModel {
            /// <summary>
            /// <para>The type of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: default filter conditions.</description></item>
            /// <item><description><b>user</b>: custom filter conditions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ConditionType")]
            [Validation(Required=false)]
            public string ConditionType { get; set; }

            /// <summary>
            /// <para>The filter condition. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>filterParams</b>: the parameters of the filter condition. The value of this field is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>labelKey</b>: the key for rendering.</para>
            /// </description></item>
            /// <item><description><para><b>label</b>: the display name.</para>
            /// </description></item>
            /// <item><description><para><b>value</b>: the value of the filter condition. The value of this field is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the filter item.</description></item>
            /// <item><description><b>value</b>: the value of the filter item.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>LogicalExp</b>: the logical relationship among the filter conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AND</b>: The filter conditions are evaluated by using a logical <b>AND</b>.</description></item>
            /// <item><description><b>OR</b>: The filter conditions are evaluated by using a logical <b>OR</b>.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> If the value of <b>ConditionType</b> is <b>system</b>, <b>labelKey</b> is returned. The labelKey field is used only for internationalization rendering.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;filterParams\&quot;:[{\&quot;labelKey\&quot;:\&quot;a|b\&quot;,\&quot;value\&quot;:\&quot;{\\\&quot;name\\\&quot;:\\\&quot;sadsasd\\\&quot;,\\\&quot;value\\\&quot;:\\\&quot;dasdsdas\\\&quot;}\&quot;}],\&quot;LogicalExp\&quot;:\&quot;OR\&quot;}</para>
            /// </summary>
            [NameInMap("FilterConditions")]
            [Validation(Required=false)]
            public string FilterConditions { get; set; }

            /// <summary>
            /// <para>The filter condition name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StopMachine</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The key of the filter condition name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop_machine</para>
            /// </summary>
            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AEC47AF-8CFA-485E-AC9A-3A8ABC06EA7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
