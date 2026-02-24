// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleOperatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of operators.</para>
        /// </summary>
        [NameInMap("Operators")]
        [Validation(Required=false)]
        public List<ListConfigRuleOperatorsResponseBodyOperators> Operators { get; set; }
        public class ListConfigRuleOperatorsResponseBodyOperators : TeaModel {
            /// <summary>
            /// <para>The data type that the operator applies to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The description of the operator, which can be used to explain why a resource is non-compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The current value must equal the target value (case insensitive)</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StringEquals</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operator for the rule\&quot;s input parameter. The available operators vary based on the data type retrieved using SelectPath.</para>
            /// <list type="bullet">
            /// <item><description><para>If the data type is String, valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>StringEquals: equals.</para>
            /// </description></item>
            /// <item><description><para>NotStringEquals: does not equal.</para>
            /// </description></item>
            /// <item><description><para>StringIn: is in.</para>
            /// </description></item>
            /// <item><description><para>NotStringIn: is not in.</para>
            /// </description></item>
            /// <item><description><para>StringContains: contains.</para>
            /// </description></item>
            /// <item><description><para>NotStringContains: does not contain.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the data type is Number, valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>Equals: equals.</para>
            /// </description></item>
            /// <item><description><para>NotEquals: does not equal.</para>
            /// </description></item>
            /// <item><description><para>Less: is less than.</para>
            /// </description></item>
            /// <item><description><para>LessOrEquals: is less than or equal to.</para>
            /// </description></item>
            /// <item><description><para>Greater: is greater than.</para>
            /// </description></item>
            /// <item><description><para>GreaterOrEquals: is greater than or equal to.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the data type is a Base64-encoded string, valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>Base64Contains: contains.</para>
            /// </description></item>
            /// <item><description><para>NotBase64Contains: does not contain.</para>
            /// </description></item>
            /// <item><description><para>Base64ContainsAll: contains all.</para>
            /// </description></item>
            /// <item><description><para>Base64ExcludeAll: excludes all.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the data type is Array, valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>Contains: contains.</para>
            /// </description></item>
            /// <item><description><para>NotContains: does not contain.</para>
            /// </description></item>
            /// <item><description><para>In: is in.</para>
            /// </description></item>
            /// <item><description><para>NotIn: is not in.</para>
            /// </description></item>
            /// <item><description><para>ContainsAll: contains all.</para>
            /// </description></item>
            /// <item><description><para>ExcludeAll: excludes all.</para>
            /// </description></item>
            /// <item><description><para>IsEmpty: is empty.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StringEquals</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A68DD98C-DE65-46AC-B2D2-04A4A9AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
